import javax.swing.*;
import java.awt.*;

public class BSALineDrawing extends JPanel {
    private final int x1, y1, x2, y2;

    public BSALineDrawing(int x1, int y1, int x2, int y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        drawLine(g, x1, y1, x2, y2);
    }

    public void drawLine(Graphics g, int x1, int y1, int x2, int y2) {
        int dx = Math.abs(x2 - x1);
        int dy = Math.abs(y2 - y1);
        int p = 2 * dy - dx;
        int x, y, end;

        if (x1 > x2) {
            x = x2;
            y = y2;
            end = x1;
        } else {
            x = x1;
            y = y1;
            end = x2;
        }

        g.drawLine(x, y, x, y);

        while (x < end) {
            x++;
            if (p < 0) {
                p += 2 * dy;
            } else {
                y++;
                p += 2 * (dy - dx);
            }
            g.drawLine(x, y, x, y);
        }
    }

    public static void main(String[] args) {
        int x1 = 100, y1 = 100, x2 = 200, y2 = 150;

        JFrame frame = new JFrame();
        BSALineDrawing panel = new BSALineDrawing(x1, y1, x2, y2);
        frame.add(panel);
        frame.setSize(250, 250);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}