import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int base = sc.nextInt();
        int power = sc.nextInt();

        double result = Math.pow(base, power);

        System.out.println(result);
    }
}
