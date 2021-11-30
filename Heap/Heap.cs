using System;
//TODO make this a generic class
public class Heap
{
    private int[] _Heap;
    private int Size;

    public Heap(int size)
    {
        _Heap = new int[size];
    }

    // O(log n)
    public void Insert(int value)
    {
        if (IsFull())
        {
            throw new System.IndexOutOfRangeException("Heap is full");
        }
        _Heap[Size++] = value;
        TrickleUp(Size);
        Size++;
    }

    // O(n)
    public int Remove(int index)
    {
        if (IsEmpty())
            throw new System.Exception("Heap is empty");
        var parent = GetParent(index);
        var removedValue = _Heap[index];
        _Heap[index] = _Heap[Size - 1];

        if(index == 0 || _Heap[index] > _Heap[parent])
        {
            TrickleDown(index, Size - 1);
        }
        else
        {
            TrickleUp(index);
        }
        Size--;
        return removedValue;
    }

    
    private void TrickleDown(int index, int lastHeapIndex)
    {
        int child_swap;

        while (index <= lastHeapIndex)
        {
            var leftChild = GetLeftChild(index);
            var rightChild = GetRightChild(index);

            if (leftChild <= lastHeapIndex)
            {
                if (rightChild > lastHeapIndex)
                {
                    child_swap = leftChild;
                }
                else
                {
                    if (_Heap[leftChild] > _Heap[rightChild])
                    {
                        child_swap = leftChild;
                    }
                    else
                    {
                        child_swap = rightChild;
                    }
                }
                if (_Heap[index] < _Heap[child_swap])
                {
                    var tmp = _Heap[index];
                    _Heap[index] = _Heap[child_swap];
                    _Heap[child_swap] = tmp;
                }
                else
                {
                    break;
                }
                index = child_swap;
            }

            else
            {
                break;
            }
        }
    }
    private void TrickleUp(int index)
    {
        var newValue = _Heap[index];
        while (index > 0 && newValue > _Heap[GetParent(index)])
        {
            _Heap[index] = _Heap[GetParent(index)];
            index = GetParent(index);
        }

        _Heap[index] = newValue;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new System.IndexOutOfRangeException("Heap is empty");
        return _Heap[0];
    }

    //TODO Do csharp syntax
    public int GetParent(int index)
    {
        return (index - 1) / 2;
    }

    //TODO Do csharp syntax
    public int GetLeftChild(int index)
    {
        return 2 * index + 1;
    }

    //TODO Do csharp syntax
    public int GetRightChild(int index)
    {
        return 2 * index + 2;
    }

    public bool IsFull()
    {
        return Size == _Heap.Length;
    }

    public bool IsEmpty()
    {
        return Size == 0;
    }

    public void PrintHeap()
    {
        for (int i = 0; i < Size; i++)
        {
            Console.Write(_Heap[i] + " ");
        }
        Console.WriteLine();
    }
}