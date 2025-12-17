import java.util.*;

class VolOfCylinder {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double r = sc.nextDouble();
        double h = sc.nextDouble();

        double v = Math.PI * r*r*h;

        System.out.println(v);
    }
}
    
