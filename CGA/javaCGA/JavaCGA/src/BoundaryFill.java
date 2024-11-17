import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.image.BufferedImage;

public class BoundaryFill extends JPanel {
    private BufferedImage image;
    private Color fillColor = Color.RED;
    private Color boundaryColor = Color.BLACK;

    public BoundaryFill() {
        image = new BufferedImage(400, 400, BufferedImage.TYPE_INT_RGB);
        Graphics g = image.getGraphics();
        g.setColor(boundaryColor);
        g.fillRect(50, 50, 300, 300);
        g.setColor(Color.WHITE);
        g.fillRect(60, 60, 280, 280);
        g.dispose();

        addMouseListener(new MouseAdapter() {
            public void mousePressed(MouseEvent e) {
                boundaryFill(e.getX(), e.getY(), fillColor.getRGB(), boundaryColor.getRGB());
                repaint();
            }
        });
    }

    public void boundaryFill(int x, int y, int fillColor, int boundaryColor) {
        if (x < 0 || x >= image.getWidth() || y < 0 || y >= image.getHeight()) return;
        if (image.getRGB(x, y) != boundaryColor && image.getRGB(x, y) != fillColor) {
            image.setRGB(x, y, fillColor);
            boundaryFill(x + 1, y, fillColor, boundaryColor);
            boundaryFill(x - 1, y, fillColor, boundaryColor);
            boundaryFill(x, y + 1, fillColor, boundaryColor);
            boundaryFill(x, y - 1, fillColor, boundaryColor);
        }
    }

    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.drawImage(image, 0, 0, null);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Boundary Fill Algorithm");
        BoundaryFill boundaryFill = new BoundaryFill();
        frame.add(boundaryFill);
        frame.setSize(400, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}