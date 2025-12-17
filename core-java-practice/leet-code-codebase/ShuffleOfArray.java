import java.util.Scanner;

public class ShuffleOfArray {

    // function
    public static int[] shuffle(int[] a, int n) {
        int[] arr = new int[2 * n];
        int x = 0;
        int y = n;

        for (int i = 0; i < n; i++) {
            arr[x] = a[i];
            arr[x + 1] = a[y];
            x += 2;
            y++;
        }
        return arr;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int[] a = new int[2 * n];

        for (int i = 0; i < 2 * n; i++) {
            a[i] = sc.nextInt();
        }
        int[] r = shuffle(a, n);
        for (int i = 0; i < r.length; i++) {
            System.out.print(r[i] + " ");
        }
    }
}
