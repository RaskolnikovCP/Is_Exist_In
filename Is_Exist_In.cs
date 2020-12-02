public bool Is_Exist_In(int[] arr, int x)
        {
            int size = arr.Length;

            bool is_Exist = false;

            for (int i = 0; i < size; i++)
            {
                if (x == arr[i])
                {
                    is_Exist = true;
                    break;
                }
            }
            return is_Exist;
        }
