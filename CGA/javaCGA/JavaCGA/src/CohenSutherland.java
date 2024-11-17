import javax.swing.*;
import java.awt.*;

public class CohenSutherland extends JPanel {
    private static final int INSIDE = 0, LEFT = 1, RIGHT = 2, BOTTOM = 4, TOP = 8;
    private int xMin = 100, yMin = 100, xMax = 300, yMax = 300;

    private int computeCode(int x, int y) {
        int code = INSIDE;
        if (x < xMin)
            code |= LEFT;
        if (x > xMax)
            code |= RIGHT;
        if (y < yMin)
            code |= BOTTOM;
        if (y > yMax)
            code |= TOP;
        return code;
    }

    private void clip(Graphics g, int x1, int y1, int x2, int y2) {
        int code1 = computeCode(x1, y1);
        int code2 = computeCode(x2, y2);

        while (true) {
            if ((code1 | code2) == 0) {
                g.drawLine(x1, y1, x2, y2);
                return;
            }

            if ((code1 & code2) != 0) {
                return;
            }

            int codeOut = (code1 != 0) ? code1 : code2;
            int x = 0, y = 0;

            if ((codeOut & TOP) != 0) {
                x = x1 + (x2 - x1) * (yMax - y1) / (y2 - y1);
                y = yMax;
            } else if ((codeOut & BOTTOM) != 0) {
                x = x1 + (x2 - x1) * (yMin - y1) / (y2 - y1);
                y = yMin;
            } else if ((codeOut & RIGHT) != 0) {
                y = y1 + (y2 - y1) * (xMax - x1) / (x2 - x1);
                x = xMax;
            } else if ((codeOut & LEFT) != 0) {
                y = y1 + (y2 - y1) * (xMin - x1) / (x2 - x1);
                x = xMin;
            }

            if (codeOut == code1) {
                x1 = x;
                y1 = y;
                code1 = computeCode(x1, y1);
            } else {
                x2 = x;
                y2 = y;
                code2 = computeCode(x2, y2);
            }
        }
    }

    @Override
    protected void paintComponent(Graphics g) {
        g.drawRect(xMin, yMin, xMax - xMin, yMax - yMin);
        int[][] lines = { { 50, 50, 200, 200 }, { 120, 350, 220, 80 }, { 90, 90, 310, 310 }, { 50, 250, 350, 250 } };
        for (int[] line : lines)
            clip(g, line[0], line[1], line[2], line[3]);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame();
        frame.add(new CohenSutherland());
        frame.setSize(400, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
