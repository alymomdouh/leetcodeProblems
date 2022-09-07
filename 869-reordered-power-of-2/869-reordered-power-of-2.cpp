class Solution {
public:
    bool reorderedPowerOf2(int N) {
        int d = getNumOfDigits(N);
        int a[10]={0};
        getDigitsFreq(N,a);
        int n2=1;
        int d1;
        for(int i=0; i<30; i++){
            d1 = getNumOfDigits(n2);
            if(d==d1){
                int a1[10]={0};
                getDigitsFreq(n2,a1);
                int j;
                for(j=0;j<10;j++){
                    if(a[j] != a1[j]){
                        break;
                    }
                }
                if(j==10){
                    return true;
                }
            }
            else if(d<d1){
                break;
            }
            n2=n2<<1;
        }
        return false;
    }

    void getDigitsFreq(int N, int a[]){
        while(N){
            a[N%10]++;
            N /= 10;
        }
    }

    int getNumOfDigits(int n){
        int i=0;
        while(n){
            i++;
            n /= 10;
        }
        return i;
    }
};