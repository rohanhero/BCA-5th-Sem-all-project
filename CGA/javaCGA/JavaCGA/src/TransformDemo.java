import javax.swing.*;
import java.awt.*;
import java.awt.geom.AffineTransform;

public class TransformDemo extends JPanel {
    private int[] xPoints = {100, 150, 200};
    private int[] yPoints = {100, 50, 100};

    private void translate(Graphics2D g2d, int tx, int ty) {
        AffineTransform translate = AffineTransform.getTranslateInstance(tx, ty);
        g2d.transform(translate);
    }

    private void rotate(Graphics2D g2d, double angle, int cx, int cy) {
        AffineTransform rotate = AffineTransform.getRotateInstance(Math.toRadians(angle), cx, cy);
        g2d.transform(rotate);
    }

    @Override
    protected void paintComponent(Graphics g) {
        Graphics2D g2d = (Graphics2D) g;
        g2d.setColor(Color.BLUE);
        g2d.drawPolygon(xPoints, yPoints, xPoints.length);

        g2d.setColor(Color.RED);
        translate(g2d, 50, 50);
        g2d.drawPolygon(xPoints, yPoints, xPoints.length);

        g2d.setColor(Color.GREEN);
        rotate(g2d, 45, 150, 100);
        g2d.drawPolygon(xPoints, yPoints, xPoints.length);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame();
        frame.add(new TransformDemo());
        frame.setSize(400, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
