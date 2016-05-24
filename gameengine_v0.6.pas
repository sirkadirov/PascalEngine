program PascalEngine;
uses graph,wincrt;

function IntToStr(i:longint):string;
var s:string;
begin
 str(i,s);
 IntToStr:=s;
end;

function sign(a:longint):longint;
begin
	if a>=0 then sign:=1
	else sign:=-1;
end;

var grmode,grdriver:integer; //Graphics variables
	x,y:longint; //Player cordinates
	vx,vy,d:longint; //Skorost
	i,j,l:integer; //For map navigation and other cycles
	n,m:integer; //Map resolution
	lives:integer; //Number of lives
	map:array[1..1000] of string; //Map
	levels:array[1..100] of string; //Levels list
	thislvl:integer; //Текущий уровень
	lvlcol:integer; //Level counter
	aicol:integer; //Number of AIs
	readytoplay:boolean; //Resume game?
	bot:array[1..200000] of Record
							x,y,vx,vy:longint;
							adv:boolean; //Advanced?
						end;
	pmoney,pxp:longint; //Player's money, health and XP
	maxall:longint; //Maximum number of xp and money points
	difficulty:integer; //Game difficulty
	key:char;
	f:text; //For internal uses only
begin
	grmode:=detect;
	initgraph(grmode,grdriver,'BGI');
	if graphresult<>0 then halt;
	cleardevice();
	//Splashscreen
	setcolor(red);
	settextstyle(0,0,7);
	outtextxy(20,20,'PascalEngine');
	settextstyle(0,0,4);
	setcolor(white);
	outtextxy(40,100,'Press any key to continue...');
	repeat
	until keypressed;
	while keypressed do readkey();
	cleardevice();
	//Reading levels list
	assign(f,'levels.dat');
	reset(f);
	lvlcol:=0;
	while not eof(f) do begin
		lvlcol:=lvlcol+1;
		readln(f,levels[lvlcol]);
	end;
	close(f);
	//Start
	repeat
		for thislvl:=1 to lvlcol do begin
			//UI
			setcolor(green);
			settextstyle(0,0,3);
			outtextxy(5,5,'Money: 0');
			setcolor(yellow);
			settextstyle(0,0,3);
			outtextxy(300,5,'XP: 0');
			setcolor(red);
			settextstyle(0,0,3);
			outtextxy(595,5,'Lives: 3');
			{
				ЧТЕНИЕ И ОТРИСОВКА КАРТЫ
				И ДРУГИЕ ПОДОБНЫЕ ДЕЙСТВИЯ
			}
			//Обнуление переменных
			aicol:=0;
			pmoney:=0;
			pxp:=0;
			maxall:=0;
			lives:=3;
			assign(f,levels[thislvl]);
			reset(f);
			n:=0;
			while not eof(f) do begin
				n:=n+1;
				readln(f,map[n]);
			end;
			close(f);
			m:=length(map[1]);
			for i:=1 to n do begin
				for j:=1 to m do begin
					case map[i,j] of
						//Wall
						'#':begin
							//setcolor(brown);
							setcolor(lightblue);
							rectangle(j*20-20,i*20-20+40,j*20,i*20+40);
							rectangle(j*20-15,i*20-20+50,j*20-5,i*20+30);
							delay(1);
						end;
						//Money
						'$':begin
							setcolor(green);
							//circle(j*20-20+10,i*20-20+10+40,3);
							settextstyle(3,0,2);
							outtextxy(j*20-20+5,i*20-20+10+35,'$');
							maxall:=maxall+10;
							delay(1);
						end;
						//Player spawnpoint
						'@':begin
							x:=j;
							y:=i;
							map[y,x]:=' ';
						end;
						//Ai horizontal
						'b':begin
							aicol:=aicol+1;
							bot[aicol].x:=j;
							bot[aicol].y:=i;
							bot[aicol].vx:=1; //Speed by X
							bot[aicol].vy:=0; //Speed by Y
							bot[aicol].adv:=false;
							map[y,x]:=' ';
						end;
						//Ai vertical
						'%':begin
							aicol:=aicol+1;
							bot[aicol].x:=j;
							bot[aicol].y:=i;
							bot[aicol].vx:=0; //Speed by X
							bot[aicol].vy:=1; //Speed by Y
							bot[aicol].adv:=false;
							map[y,x]:=' ';
						end;
						//Advanced AI
						'B':begin
							aicol:=aicol+1;
							bot[aicol].x:=j;
							bot[aicol].y:=i;
							bot[aicol].vx:=0; //Speed by X
							bot[aicol].vy:=1; //Speed by Y
							bot[aicol].adv:=true;
							map[y,x]:=' ';
						end;
						//XP
						'*':begin
							setcolor(yellow);
							settextstyle(3,0,2);
							outtextxy(j*20-20+5,i*20-20+10+35,'+');
							maxall:=maxall+5;
						end;
					end;
				end;
			end;
			//Game logic
			vx:=0;
			vy:=0;
			{
				ОСНОВНОЙ ИГРОВОЙ ЦИКЛ
			}
			repeat
				//Paint as transperent
				setcolor(0);
				setfillstyle(1,black);
				fillellipse((x-1)*20+10,(y-1)*20+10+40,8,8);
				for i:=1 to aicol do fillellipse((bot[i].x-1)*20+10,(bot[i].y-1)*20+10+40,8,8);
				//Keyboard reading
				if keypressed then case readkey of
					#32:begin
						vx:=0;
						vy:=0;
					end;
					#119:begin
						vy:=-1;
						vx:=0;
					end;
					#115:begin
						vy:=1;
						vx:=0;
					end;
					#97:begin
						vy:=0;
						vx:=-1;
					end;
					#100:begin
						vy:=0;
						vx:=1;
					end;
					#27:begin
						key:=#32;
						setfillstyle(1,black);
						bar(1,1,getmaxx,39);
						setcolor(red);
						settextstyle(0,0,3);
						outtextxy(20,10,'Press Esc to continue or E for exit');
						repeat
							key:=readkey;
						until (key=#27)or(key in ['E','e']);
						if key in ['E','e'] then halt;
					end;
					//Cheatcode TAB
					#9:begin
						pmoney:=maxall;
						pxp:=0;
					end;
				end;
				while keypressed do readkey();
				//Base bot navigation
				for i:=1 to aicol do begin
					if map[bot[i].y+bot[i].vy,bot[i].x+bot[i].vx]='#' then begin
						bot[i].vx:=-bot[i].vx;
						bot[i].vy:=-bot[i].vy;
					end;
					if (bot[i].x=x)and(bot[i].y=y) then lives:=lives-1; //Если поймался
				end;
				//AI NAVIGATION
				for i:=1 to aicol do begin
					//Advanced AI navigation
					if bot[i].adv=true then begin
						if bot[i].vx<>0 then begin
							d:=sign(y-bot[i].y);
							if map[bot[i].y+d,bot[i].x]<>'#' then begin
								bot[i].vx:=0;
								bot[i].vy:=d;
							end;
						end
						else begin
							d:=sign(x-bot[i].x);
							if map[bot[i].y+d,bot[i].x+d]<>'#' then begin
								bot[i].vx:=d;
								bot[i].vy:=0;
							end;
						end;
						if map[bot[i].y+bot[i].vy,bot[i].x+bot[i].vx]='#' then begin
							if bot[i].vx<>0 then begin
								d:=sign(bot[i].y-y);
								if map[bot[i].y+d,bot[i].x]<>'#' then begin
									bot[i].vy:=d;
									bot[i].vx:=0;
								end;
							end
							else begin
								d:=sign(bot[i].y-y);
								if map[bot[i].y,bot[i].x+d]<>'#' then begin
									bot[i].vy:=0;
									bot[i].vx:=d;
								end;
							end;
						end;
					end
					else begin
						//Simple AI navigation
						if map[bot[i].y+bot[i].vy,bot[i].x+bot[i].vx]='#' then begin
							bot[i].vx:=-bot[i].vx;
							bot[i].vy:=-bot[i].vy;
						end;
					end;
				end;
				if map[y+vy,x+vx]='#' then begin
					vx:=0;
					vy:=0;
				end
				else if map[y+vy,x+vx]='$' then begin
					pmoney:=pmoney+10;
					map[y+vy,x+vx]:=' ';
					setfillstyle(1,black);
					fillellipse((x+vx-1)*20+10,(y+vy-1)*20+10+40,8,8);
				end
				else if map[y+vy,x+vx]='*' then begin
					pxp:=pxp+5;
					map[y+vy,x+vx]:=' ';
					setfillstyle(1,black);
					fillellipse((x+vx-1)*20+10,(y+vy-1)*20+10+40,8,8);
				end;
				x:=x+vx;
				y:=y+vy;
				vx:=0;
				vy:=0;
				for i:=1 to aicol do begin
					bot[i].x:=bot[i].x+bot[i].vx;
					bot[i].y:=bot[i].y+bot[i].vy;
				end;
				//Re-paint
				setcolor(yellow);
				setfillstyle(1,yellow);
				fillellipse((x-1)*20+10,(y-1)*20+10+40,8,8);
				setcolor(red);
				for i:=1 to aicol do begin
					setfillstyle(1,lightred);
					fillellipse((bot[i].x-1)*20+10,(bot[i].y-1)*20+10+40,8,8);
				end;
				//UI
				setcolor(black);
				for i:=1 to 39 do rectangle(i,i,3000,39);
				setfillstyle(1,black);
				bar(1,1,getmaxx,39);
				setcolor(green);
				settextstyle(0,0,3);
				outtextxy(5,5,'Money: ' + IntToStr(pmoney));
				setcolor(yellow);
				settextstyle(0,0,3);
				outtextxy(300,5,'XP: ' + IntToStr(pxp));
				setcolor(red);
				settextstyle(0,0,3);
				outtextxy(595,5,'Lives: ' + IntToStr(lives));
				delay(100);
			until (lives=0)or((pmoney+pxp)>=maxall);
			if lives=0 then begin
				setcolor(red);
				for i:=1 to getmaxy do line(0,i,getmaxx,i);
				setcolor(white);
				settextstyle(0,0,6);
				outtextxy(getmaxx div 4,getmaxy div 2,'YOU DIED!');
				repeat
				until keypressed;
				while keypressed do readkey();
				break;
			end;
			cleardevice();
		end;
		cleardevice();
		setcolor(blue);
		//for i:=1 to getmaxy do line(0,i,getmaxx,i);
		setfillstyle(1,black);
		bar(1,1,getmaxx,39);
		setcolor(white);
		settextstyle(0,0,4);
		outtextxy(getmaxx div 3,getmaxy div 2, 'Play again?) Y/N');
		repeat
		until keypressed();
		key:=readkey();
		if key in ['N','n'] then break;
		while keypressed do readkey();
		cleardevice();
	until 1=2000000;
	closegraph();
end.