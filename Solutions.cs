using System;
using System.Collections.Generic;
using System.Linq;

public static class Solutions {
    public static string HighAndLow(string a_numbers) {
        //IEnumerable<int> _parsed = a_numbers.Split(' ').Select(int.Parse);
        //return $"{_parsed.Max()} {_parsed.Min()}";

        // Faster 
        string[] _numsStr = a_numbers.Split(' ');
        List<int> _nums = new List<int>();

        foreach(string _str in _numsStr) _nums.Add(int.Parse(_str));

        return $"{_nums.Max()} {_nums.Min()}";
    }

    public static string AlphabetPosition(string a_text) {
        string _result = "";

        for(int i=0; i<a_text.Length; i++) {
            if (char.IsLetter(a_text[i])) {
                _result += (a_text[i] & 31) + " ";
            }
        }

        return _result.TrimEnd();
    }

    public static IEnumerable<int> GetIntegersFromList(List<object> a_l) {
        return a_l.OfType<int>();
    }

    public static int DigitalRoot(long a_n) {
        string _str = a_n.ToString();
        while(_str.Length > 1) {
            _str = a_n.ToString();
         
            List<int> _nums = new List<int>();
            foreach (char _c in _str) _nums.Add(int.Parse(_c.ToString()));
            
            a_n = _nums.Sum();
        }

        return (int)a_n;
    }

    public static string Accum(string a_s) {
        string _result = "";

        for(int i=0; i < a_s.Length; i++) {
            _result += a_s[i].ToString().ToUpper();
            for(int x=0; x<i; x++) {
                _result += a_s[i].ToString().ToLower();
            }

            _result += "-";
        }

        return _result.Remove(_result.Length-1, 1);
    }

    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> a_i) {
        List<T> _numerable = new List<T>();
        for(int i=0; i<a_i.Count(); i++) {
            if(i==0 || !a_i.ToArray()[i-1].Equals(a_i.ToArray()[i])) {
                _numerable.Add(a_i.ToArray()[i]);
            }
        }

        return _numerable;
    }

    public static int[] DeleteNth(int[] a_arr, int a_n) {
        List<int> _result = new List<int>();

        for(int i=0; i<a_arr.Length; i++) {
            if(_result.Where(x => x == a_arr[i]).Count() < a_n) {
                _result.Add(a_arr[i]);
            }
        }

        return _result.ToArray();
    }

    public static bool IsPangram(string a_str) {
        return a_str.ToLower().Where(ch => char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
    }

    public static int GetUnique(IEnumerable<int> a_nums) {
        int _result = 0;
        List<int> _nums = a_nums.ToList();

        for(int i=0; i<_nums.Count(); i++) {
            if(i==0 || _nums.Where(x => x == _nums[i]).Count() == 1) {
                _result = _nums[i];
            }
        }

        return _result;
    }

    public static string GetReadableTime(int a_seconds){
        TimeSpan _time = TimeSpan.FromSeconds(a_seconds);
        return $"{_time.Hours:00}:{_time.Minutes:00}:{_time.Seconds:00}";
    }

    public static int CountSheeps(bool[] a_sheeps) {
        return a_sheeps.Where(x => x == true).Count();
    }

    public static int DescendingOrder(int a_n) {
        return int.Parse(string.Concat(a_n.ToString().OrderByDescending(x => x)));
    }

    public static string PigIt(string a_str) {
        string _result = "";

        string[] _strs = a_str.Split(' ');

        for(int i=0; i<_strs.Length; i++){
            if(_strs[i].Length > 1){
                char _start = _strs[i][0];
                _result += $"{_strs[i].Substring(1)}{_start}ay ";
            }else{
                _result += _strs[i];
            }
        }

        return _result.TrimEnd();
    }

    public static long FindNb(long a_m) {
        long _n=0;

        while(true){
            if(a_m > 0){
                long _v = (long)System.Numerics.BigInteger.Pow(_n+1, 3);
                a_m -= _v;
            }else if(a_m==0){
                return _n;
            }else if(a_m < 0){
                return -1;
            }

            _n++;
        }
    }
}