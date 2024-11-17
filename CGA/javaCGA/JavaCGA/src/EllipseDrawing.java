import javax.swing.*;
import java.awt.*;

public class EllipseDrawing extends JPanel {

    private void drawEllipse(Graphics g, int h, int k, int a, int b) {
        int x = 0, y = b;
        int a2 = a * a, b2 = b * b;
        int twob2 = 2 * b2, twoma2 = 2 * a2;

        // Draw initial points
        g.fillOval(h + x, k - y, 3, 3);
        g.fillOval(h - x, k - y, 3, 3);
        g.fillOval(h + x, k + y, 3, 3);
        g.fillOval(h - x, k + y, 3, 3);
        // Region 1
        int p = (int) (b2 - a2 * b + 0.25 * a2);
        while (b2 * x < a2 * y) {
            x++;
            if (p < 0) {
                p += b2 * (2 * x + 3);
            } else {
                y--;
                p += b2 * (2 * x + 3) + a2 * (-2 * y + 2);
            }
            g.fillOval(h + x, k - y, 3, 3);
            g.fillOval(h - x, k - y, 3, 3);
            g.fillOval(h + x, k + y, 3, 3);
            g.fillOval(h - x, k + y, 3, 3);
        }

        // Region 2
        p = (int) (b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2);
        while (y > 0) {
            y--;
            if (p > 0) {
                p += a2 * (-2 * y + 3);
            } else {
                x++;
                p += b2 * (2 * x + 2) + a2 * (-2 * y + 3);
            }
            g.fillOval(h + x, k - y, 3, 3);
            g.fillOval(h - x, k - y, 3, 3);
            g.fillOval(h + x, k + y, 3, 3);
            g.fillOval(h - x, k + y, 3, 3);
        }
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        int h = 300, k = 300, a = 200, b = 100;
        drawEllipse(g, h, k, a, b);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Ellipse Drawing Algorithm");
        EllipseDrawing ellipsePanel = new EllipseDrawing();
        frame.add(ellipsePanel);
        frame.setSize(600, 600);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
