// Question: Mid-Point Circle Drawing Algorithm
#include <stdio.h>
#include <graphics.h>
#include <math.h>

void drawCircle(int x1, int y1, int radius) {
    int x = 0;
    int y = radius;
    int p = 1 - radius;

    putpixel(x1 + x, y1 + y, WHITE);

    while (x <= y) {
        putpixel(x1 + x, y1 + y, WHITE);
        putpixel(x1 + y, y1 + x, WHITE);
        putpixel(x1 - y, y1 + x, WHITE);
        putpixel(x1 - x, y1 + y, WHITE);
        putpixel(x1 - x, y1 - y, WHITE);
        putpixel(x1 - y, y1 - x, WHITE);
        putpixel(x1 + y, y1 - x, WHITE);
        putpixel(x1 + x, y1 - y, WHITE);

        if (p < 0) {
            p += 2 * x + 3;
        } else {
            p += 2 * (x - y) + 5;
            y--;
        }
        x++;
    }
}

int main() {
    int gd = DETECT, gm;
    int x1, y1, radius;

    printf("Enter the coordinates of the center of the circle: ");
    scanf("%d %d", &x1, &y1);

    printf("Enter the radius of the circle: ");
    scanf("%d", &radius);

    initgraph(&gd, &gm, NULL);

    drawCircle(x1, y1, radius);

    getch();
    closegraph();

    return 0;
}

