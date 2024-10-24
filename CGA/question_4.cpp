// Question: Mid-Point Ellipse Drawing ALgorithm
#include <graphics.h>
#include <stdio.h>
#include <math.h>
int main()
{
    int xc, yc, x, y, rx, ry;
    float p;
    int gd = DETECT, gm;
    initgraph(&gd, &gm, NULL);
    printf("Enter coordinates of centre : \n");
    scanf("%d %d", &xc, &yc);
    printf("Enter x,y radius of ellipse:\n ");
    scanf("%d %d", &rx, &ry);
    // Region 1
    p = ry * ry - rx * rx * ry + rx * rx / 4;
    x = 0;
    y = ry;
    while (2.0 * ry * ry * x <= 2.0 * rx * rx * y)
    {
        if (p < 0)
        {
            x++;
            p = p + 2 * ry * ry * x + ry * ry;
        }
        else
        {
            x++;
            y--;
            p = p + 2 * ry * ry * x - 2 * rx * rx * y - ry * ry;
        }
        putpixel(x + xc, y + yc, WHITE);
        putpixel(-x + xc, y + yc, WHITE);
        putpixel(x + xc, -y + yc, WHITE);
        putpixel(-x + xc, -y + yc, WHITE);
    }
    // Region 2
    p = ry * ry * (x + 0.5) * (x + 0.5) + rx * rx * (y - 1) * (y - 1) - rx * rx * ry * ry;
    while (y > 0)
    {
        if (p <= 0)
        {
            x++;
            y--;
            p = p + 2 * ry * ry * x - 2 * rx * rx * y + rx * rx;
        }
        else
        {
            y--;
            p = p - 2 * rx * rx * y + rx * rx;
        }
        putpixel(x + xc, y + yc, WHITE);
        putpixel(-x + xc, y + yc, WHITE);
        putpixel(x + xc, -y + yc, WHITE);
        putpixel(-x + xc, -y + yc, WHITE);
    }
    getch();
    closegraph();
}
