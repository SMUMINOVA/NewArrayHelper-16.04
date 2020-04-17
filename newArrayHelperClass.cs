using System;
namespace NewArrayHelper
{
    public static class ArrayHelper <T>
    {
        //public static T[] arr{get; set;}
        public static T Pop(ref T[] arr){
                T value = arr [arr.Length-1];
                T[] newArr = new T [arr.Length-1];
                for (int i = 0; i < newArr.Length; i++){
                    newArr[i] = arr[i];
                }
                arr = newArr;
                return value;
            }
        public static int Push(ref T[] arr, T x){
                T[] newArr = new T[arr.Length + 1];
                for (int i = 0; i < arr.Length; i ++){
                    newArr[i] = arr[i];
                }
                newArr[newArr.Length-1] = x;
                arr = newArr;
                return arr.Length;
            }
        public static T Shift(ref T[] arr){
                T[] newArr = new T [arr.Length - 1];
                for (int i = 1, j = 0; j < newArr.Length; j++, i++){
                    newArr[j] = arr[i];
                }
                T x = arr[0];
                arr = newArr;
                return x;
            }
        public static int UnShift(ref T[] arr, T x){
                T[] newArr = new T [arr.Length + 1];
                for (int i = 0, j = 1; i < arr.Length; i ++, j++){
                    newArr[j] = arr[i];
                }
                newArr[0] = x;
                arr = newArr;
                return arr.Length;
            }
        
        public static T[] Slice(T[] arr, int beginIndex = 0, int endIndex = 0){
            if (Math.Abs(beginIndex) > arr.Length || Math.Abs(beginIndex) > arr.Length){
                T[] newArr = new T [0];
                return newArr;
            }
            if (endIndex < 0)
                endIndex = arr.Length + endIndex;
            if (beginIndex < 0 )
                beginIndex = arr.Length + beginIndex ;
            if (endIndex == 0)
                endIndex = arr.Length ;
            T[] newArr1 = new T [Math.Abs(endIndex - beginIndex)];
            if(endIndex < beginIndex){
                for (int i = beginIndex, j = 0; i > endIndex; i--, j++)
                    newArr1[j] = arr[i];
            }
            else for (int i = beginIndex, j = 0; i < endIndex; i++, j++)
                    newArr1[j] = arr[i];
            return newArr1;

        }
    }
}