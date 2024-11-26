import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

public class BoundaryFill extends JPanel {
    private BufferedImage img;

    public BoundaryFill() {
        img = new BufferedImage(500, 500, BufferedImage.TYPE_INT_RGB);
        Graphics g = img.getGraphics();
        g.setColor(Color.WHITE);
        g.fillRect(0, 0, 500, 500);
        g.setColor(Color.BLACK);
        g.drawRect(100, 100, 300, 300);
    }

    private void fill(int x, int y, Color fc, Color bc) {
        if (x < 0 || y < 0 || x >= img.getWidth() || y >= img.getHeight()) return;
        Color c = new Color(img.getRGB(x, y));
        if (!c.equals(bc) && !c.equals(fc)) {
            img.setRGB(x, y, fc.getRGB());
            fill(x + 1, y, fc, bc);
            fill(x - 1, y, fc, bc);
            fill(x, y + 1, fc, bc);
            fill(x, y - 1, fc, bc);
        }
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.drawImage(img, 0, 0, null);
    }

    public static void main(String[] args) {
        JFrame f = new JFrame();
        BoundaryFill p = new BoundaryFill();
        f.add(p);
        f.setSize(500, 500);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
        SwingUtilities.invokeLater(() -> {
            p.fill(250, 250, Color.RED, Color.BLACK);
            p.repaint();
        });
    }
}
