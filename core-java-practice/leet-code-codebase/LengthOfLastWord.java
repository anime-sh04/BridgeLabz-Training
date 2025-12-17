import java.util.*;
class LengthOfLastWord {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String st = sc.nextLine();
        int ans = word(st);

        System.out.println(ans);
    }
    public static int word(String s) {
        int c = 0;
        boolean found = false;

        for (int i = s.length() - 1; i >= 0; i--) {
            char ch = s.charAt(i);

            if (ch == ' ' && !found) {
                continue;
            } else if (ch == ' ' && found) {
                break;
            } else {
                c++;
                found = true;
            }
        }
        return c;
    }
}
