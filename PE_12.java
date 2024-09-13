import java.util.ArrayList;
import java.util.List;

public class PE_12 {
    static class pPrimes {
        int pfactor;
        int count = 0; 
    }
    public static void main(String args[]) {

        int n = 10000; //Number of divisibles (and primes to create for safety)
        List<Integer> primes = new ArrayList<Integer> (0);
        
        //Finds the first n primes
        int count = 2;
        while (primes.size() <= n) {
            boolean isPrime = true;
            for (Integer prime : primes) {
                double value = Double.valueOf(count) / Double.valueOf(prime);
                if (Math.round(value) == value) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                primes.add(count);
            }
            count++;
        }

        int divisibles = 0;
        count = 3;
        int increaser = 3;
        //Repeat for every number to check
        while (divisibles <= 500) {
            int i = 0;
            divisibles = 1;
            List<pPrimes> personalPrimes = new ArrayList<pPrimes>(0);
            double value = count;

            while (value != 1) {
                boolean stillDivisble = true;
                while (stillDivisble) {
                    double check = value / primes.get(i);
                    if (check == Math.round(check)) {
                        value = check;
                        stillDivisble = true;
                        boolean newPrime = true;
                        for (int a = 0; a < personalPrimes.size(); a++) {
                            if (personalPrimes.get(a).pfactor == primes.get(i)) {
                                personalPrimes.get(a).count++;
                                newPrime = false;
                                break;
                            }
                        }
                        if (newPrime) {
                            pPrimes onePrime = new pPrimes();
                            onePrime.count = 1;
                            onePrime.pfactor = primes.get(i);
                            personalPrimes.add(onePrime);
                        }
                    } else {
                        stillDivisble = false;
                    }
                }
                i++;
            }

            for (int a = 0; a < personalPrimes.size(); a++) {
                divisibles *= personalPrimes.get(a).count + 1;
            }
            count += increaser;
            increaser += 1;
        }
        System.out.println(count);;
    }
}