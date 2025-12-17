import java.util.*;

public class PowerOfThree {
    public static boolean power(int n) {
        if (n <= 0) {
            return false;
        }
        if (n == 1) {
            return true;
        }
        if (n % 3 != 0) {
            return false;
        }
        return power(n / 3);
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();

        if (power(n)) {
            System.out.println("It is  power of 3");
        } else {
            System.out.println("It is NOT");
        }
    }
}
