import javax.swing.*;
import java.awt.*;

public class MidpointCircleDrawing extends JPanel {
    int xCenter, yCenter, radius;

    public MidpointCircleDrawing(int xCenter, int yCenter, int radius) {
        this.xCenter = xCenter;
        this.yCenter = yCenter;
        this.radius = radius;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        int x = 0, y = radius;
        int p = 1 - radius;
        plotCirclePoints(g, xCenter, yCenter, x, y);

        while (x < y) {
            x++;
            if (p < 0) p += 2 * x + 1;
            else { y--; p += 2 * (x - y) + 1; }
            plotCirclePoints(g, xCenter, yCenter, x, y);
        } 
    }

    private void plotCirclePoints(Graphics g, int xc, int yc, int x, int y) {
        g.fillRect(xc + x, yc + y, 1, 1);
        g.fillRect(xc - x, yc + y, 1, 1);
        g.fillRect(xc + x, yc - y, 1, 1);
        g.fillRect(xc - x, yc - y, 1, 1);
        g.fillRect(xc + y, yc + x, 1, 1);
        g.fillRect(xc - y, yc + x, 1, 1);
        g.fillRect(xc + y, yc - x, 1, 1);
        g.fillRect(xc - y, yc - x, 1, 1);
    }

    public static void main(String[] args) {
        int xCenter = Integer.parseInt(JOptionPane.showInputDialog("Enter x:"));
        int yCenter = Integer.parseInt(JOptionPane.showInputDialog("Enter y:"));
        int radius = Integer.parseInt(JOptionPane.showInputDialog("Enter radius:"));

        JFrame frame = new JFrame();
        frame.add(new MidpointCircleDrawing(xCenter, yCenter, radius));
        frame.setSize(500, 500);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
