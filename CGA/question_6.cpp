/*
Question: Write a program to implement 2D transformation, Rotation and Scaling in a triangle polygon.
a. Translation with translation vector tx=2 and ty=2 b. Scaling with scaling factor sx=2 and
sy=2. c. Rotation about y axis by 45 degrees in counter clockwise direction.
*/

#include <graphics.h>
#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <math.h>
int main()
{
    int gm;
    int gd = DETECT;
    int x1, x2, x3, y1, y2, y3, nx1, nx2, nx3, ny1, ny2, ny3, c;
    int sx, sy, xt, yt, r;
    float t;
    initgraph(&gd, &gm, "c:\\tc\\bg:");
    printf("\t Program for basic transactions");
    printf("\n\t Enter the points of the triangle");
    setcolor(1);
    scanf("%d%d%d%d%d%d", &x1, &y1, &x2, &y2, &x3, &y3);
    line(x1, y1, x2, y2);
    line(x2, y2, x3, y3);
    line(x3, y3, x1, y1);
    printf("\n 1.Translation\n 2.Rotation\n 3.Scaling\n 4.Exit");
    printf("\nEnter your choice: ");
    scanf("%d", &c);
    switch (c)
    {
    case 1:
        printf("\n Enter the translation factors (xt yt): ");
        scanf("%d%d", &xt, &yt);
        nx1 = x1 + xt;
        ny1 = y1 + yt;
        nx2 = x2 + xt;
        ny2 = y2 + yt;
        nx3 = x3 + xt;
        ny3 = y3 + yt;
        setcolor(5);
        line(nx1, ny1, nx2, ny2);
        line(nx2, ny2, nx3, ny3);
        line(nx3, ny3, nx1, ny1);
        getch();
        break;
    case 2:
        printf("\n Enter the angle of rotation (degrees): ");
        scanf("%d", &r);
        t = 3.14 * r / 180;
        nx1 = abs(x1 * cos(t) - y1 * sin(t));
        ny1 = abs(x1 * sin(t) + y1 * cos(t));
        nx2 = abs(x2 * cos(t) - y2 * sin(t));
        ny2 = abs(x2 * sin(t) + y2 * cos(t));
        nx3 = abs(x3 * cos(t) - y3 * sin(t));
        ny3 = abs(x3 * sin(t) + y3 * cos(t));
        setcolor(5);
        line(nx1, ny1, nx2, ny2);
        line(nx2, ny2, nx3, ny3);
        line(nx3, ny3, nx1, ny1);
        getch();
        break;
    case 3:
        printf("\n Enter the scaling factors (sx sy): ");
        scanf("%d%d", &sx, &sy);
        nx1 = x1 * sx;
        ny1 = y1 * sy;
        nx2 = x2 * sx;
        ny2 = y2 * sy;
        nx3 = x3 * sx;
        ny3 = y3 * sy;
        setcolor(5);
        line(nx1, ny1, nx2, ny2);
        line(nx2, ny2, nx3, ny3);
        line(nx3, ny3, nx1, ny1);
        getch();
        break;
    case 4:
        break;
    default:
        printf("Enter the correct choice");
    }
    closegraph();
    return 0;
}