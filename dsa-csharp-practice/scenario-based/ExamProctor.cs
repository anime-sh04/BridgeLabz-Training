using System;

class ExamProctor
{
    class Stack
    {
        int[] stack;
        int top;
        int size;

        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }

        public void Push(int questionId)
        {
            if (top < size - 1)
            {
                stack[++top] = questionId;
            }
        }

        public int Pop()
        {
            if (top >= 0)
                return stack[top--];
            return -1;
        }

        public int Peek()
        {
            if (top >= 0)
                return stack[top];
            return -1;
        }
    }
    class Entry
    {
        public int Key;     // questionID
        public char Value;  // answer

        public Entry(int key, char value)
        {
            Key = key;
            Value = value;
        }
    }

    class AnswerMap
    {
        int SIZE = 20;
        Entry[] table;

        public AnswerMap()
        {
            table = new Entry[SIZE];
        }

        int Hash(int key)
        {
            return key % SIZE;
        }

        public void Put(int key, char value)
        {
            int index = Hash(key);

            while (table[index] != null)
            {
                if (table[index].Key == key)
                {
                    table[index].Value = value; // update
                    return;
                }
                index = (index + 1) % SIZE;
            }

            table[index] = new Entry(key, value);
        }

        public char Get(int key)
        {
            int index = Hash(key);

            while (table[index] != null)
            {
                if (table[index].Key == key)
                    return table[index].Value;
                index = (index + 1) % SIZE;
            }

            return '-'; // not answered
        }
    }
    static int CalculateScore(AnswerMap answers, char[] correctAnswers)
    {
        int score = 0;

        for (int qid = 0; qid < correctAnswers.Length; qid++)
        {
            if (answers.Get(qid) == correctAnswers[qid])
                score++;
        }

        return score;
    }
    
    static void Main()
    {
        Stack navigationStack = new Stack(10);
        AnswerMap answerMap = new AnswerMap();
        navigationStack.Push(0);
        navigationStack.Push(1);
        navigationStack.Push(2);


        answerMap.Put(0, 'A');
        answerMap.Put(1, 'C');
        answerMap.Put(2, 'B');

        char[] correctAnswers = { 'C', 'C', 'B' };
        
        int finalScore = CalculateScore(answerMap, correctAnswers);

        Console.WriteLine("Last Visited Question ID: " + navigationStack.Peek());
        Console.WriteLine("Final Score: " + finalScore);
    }
}
