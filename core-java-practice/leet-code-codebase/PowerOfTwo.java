import java.util.Scanner;

public class PowerOfTwo {
    public static boolean power(int n) {
        if (n == 1) {
            return true;
        }
        if (n <= 0) {
            return false;
        }
        if (n % 2 != 0) {
            return false;
        }
        return power(n / 2);
    }

    // main method
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();

        if (power(n)) {
            System.out.println("Power of Two");
        } else {
            System.out.println("Not Power of Two");
        }
    }
}
