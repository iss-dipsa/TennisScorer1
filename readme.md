## Tennis Scorer Part 1 ##

Your task is to write C# code to display the score of a tennis game according to the common way score calling is done in tennis.

The table below shows what is the common score calling based on the number of points won. In the table below A is the server and B is the opponent

| A | B | Score           |
|---|:-:| ---------------:|
| 0 | 0 | Love all        |
| 0 | 1 | Love-15         |
| 0 | 2 | Love-30         |
| 0 | 3 | Love-40         |
| 0 | 4 | Game B          |
| 0 | 5 | N/A             |
| 1 | 0 | 15-love         |
| 1 | 1 | 15 all          |
| 1 | 2 | 15-30           |
| 1 | 3 | 15-40           |
| 1 | 4 | Game B          |
| 1 | 5 | N/A             |
| 2 | 0 | 30-love         |
| 2 | 1 | 30-15           |
| 2 | 2 | 30 all          |
| 2 | 3 | 30-40           |
| 2 | 4 | Game B          |
| 2 | 5 | N/A             |
| 3 | 0 | 40-love         |
| 3 | 1 | 40-15           |
| 3 | 2 | 40-30           |
| 3 | 3 | Deuce           |
| 3 | 4 | Advantage B     |
| 3 | 5 | Game B          |
| 4 | 0 | Game A          |
| 4 | 1 | Game A          |
| 4 | 2 | Game A          |
| 4 | 3 | Advantage A     |
| 4 | 4 | Deuce           |
| 4 | 5 | Advantage B     |
| 5 | 0 | N/A             |
| 5 | 1 | N/A             |
| 5 | 2 | N/A             |
| 5 | 3 | Game A          |
| 5 | 4 | Advantage A     |
| 5 | 5 | Deuce           | 

The expected output of the program is:
```
0 0 = Love all
0 1 = Love-15
0 2 = Love-30
0 3 = Love-40
0 4 = Game B
0 5 = N/A
1 0 = 15-love
1 1 = 15 all
1 2 = 15-30
1 3 = 15-40
1 4 = Game B
1 5 = N/A
2 0 = 30-love
2 1 = 30-15
2 2 = 30 all
2 3 = 30-40
2 4 = Game B
2 5 = N/A
3 0 = 40-love
3 1 = 40-15
3 2 = 40-30
3 3 = Deuce
3 4 = Advantage B
3 5 = Game B
4 0 = Game A
4 1 = Game A
4 2 = Game A
4 3 = Advantage A
4 4 = Deuce
4 5 = Advantage B
5 0 = N/A
5 1 = N/A
5 2 = N/A
5 3 = Game A
5 4 = Advantage A
5 5 = Deuce
```