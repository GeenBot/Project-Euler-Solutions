
{
    'use strict';
    //maxVal == 20
    const maxVal = 20;

    var totalFactors = [];
    var tempFactors = []
    for (var i = 2; i < maxVal + 1; i++) {
        totalFactors[i] = 0;
     }
    for (var i = 2; i < maxVal + 1; i++) {
        tempFactors = FindFactors(i);
        for (var j = 0; j < tempFactors.length; j++) {
            if (totalFactors[j] < tempFactors[j]) {
                totalFactors[j] = tempFactors[j];
            }
        }
    }
    var num = 1;
    for (var i = 2; i < totalFactors.length; i++) {
        for (var j = 0; j < totalFactors[i]; j++) {
            num *= i;
        }
    }
    console.log(num);
}


function FindFactors(val) {
    var factors = new Array;
    
    for (var i = 2; i < val + 1; i++) {
        count = 0;
        factors[i] = 0
        while (val % i == 0) {
            factors[i] += 1
            val /= i;
        }
    }
    return factors;
}

