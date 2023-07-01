public class Solution {
    public int RomanToInt(string s) {
       var roman = s.ToList();
       var sum = 0;
       for (int i = 0; i < roman.Count(); i++) {
           switch (roman[i])
           {
               case('I'):
                    if (roman.Count() != i + 1 && 
                    (roman[i+1] == 'V' || 
                    roman[i+1] == 'X'))
                    {
                        if (roman[i+1] == 'V')
                        {
                            sum += 4;
                            i++;
                        }
                        else
                        {
                            sum += 9;
                            i++;
                        }
                    }
                    else sum++;
                    break;

                case ('V'):
                    sum += 5;
                    break;

                case ('X'):
                    if (roman.Count() != i + 1 && 
                    (roman[i+1] == 'L' || 
                    roman[i+1] == 'C'))
                    {
                        if (roman[i+1] == 'L')
                        {
                            sum += 40;
                            i++;
                        }
                        else
                        {
                            sum += 90;
                            i++;
                        }
                    }
                    else sum += 10;
                    break;

                case ('L'):
                    sum += 50;
                    break;
                
                case ('C'):
                    if (roman.Count() != i + 1 && 
                    (roman[i+1] == 'D' || 
                    roman[i+1] == 'M'))
                    {
                        if (roman[i+1] == 'D')
                        {
                            sum += 400;
                            i++;
                        }
                        else
                        {
                            sum += 900;
                            i++;
                        }
                    }
                    else sum += 100;
                    break;

                case ('D'):
                    sum += 500;
                    break;
                
                case ('M'):
                    sum += 1000;
                    break;

                default:
                    break;
           }
            
       }
       return sum;
    }
}
