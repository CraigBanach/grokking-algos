Array.ForEach(SelectionSort.Sort(new int[]{5, 3, 6, 2, 10}), Console.WriteLine);

public class SelectionSort {
    public static int FindSmallest(int[] array) {
        int smallest = array[0];
        int smallestIndex = 0;

        for (int i = 1; i < array.Length; i++) {
            if (array[i] < smallest) {
                smallest = array[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }

    public static int[] Sort(int[] array) {
        int[] copiedArray = new int[array.Length];
        Array.Copy(array, copiedArray, array.Length);
        int[] sortedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++) {
            int smallestIndex = FindSmallest(copiedArray);
            sortedArray[i] = copiedArray[smallestIndex];
            for (int j = smallestIndex; j < copiedArray.Length - 1; j++) {
                copiedArray[j] = copiedArray[j + 1];
            }
            Array.Resize(ref copiedArray, copiedArray.Length - 1);
        }

        return sortedArray;
    }
}
