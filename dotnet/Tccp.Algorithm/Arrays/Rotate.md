# Rotating an Array by K positions

```
        public void ReverseArray(int[] array, int start, int end)
        {
            for (int i = start, j=end; i < j; i++, j--)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp; 
            }
        }
```
