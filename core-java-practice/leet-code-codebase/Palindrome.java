import java.util.Scanner;

public class Palindrome {

    // Function to check palindrome
    static boolean ispalin(int n) {
        int i = n;
        int r = 0;
        while (n != 0) {
            int d = n % 10;
            r = r * 10 + d;
            n = n / 10;
        }
        return i == r;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();

        if (ispalin(n)) {
            System.out.println("Its a palin");
        } else {
            System.out.println("Its not");
        }
    }
}
