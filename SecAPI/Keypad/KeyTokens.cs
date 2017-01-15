using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecAPI.Keypad
{
    public static class KeyTokens
    {
        public static char GetToken(Key Key)
        {
            switch (Key)
            {
                case Keypad.Key.Digit_0:
                    return '0';
                case Keypad.Key.Digit_1:
                    return '1';
                case Keypad.Key.Digit_2:
                    return '2';
                case Keypad.Key.Digit_3:
                    return '3';
                case Keypad.Key.Digit_4:
                    return '4';
                case Keypad.Key.Digit_5:
                    return '5';
                case Keypad.Key.Digit_6:
                    return '6';
                case Keypad.Key.Digit_7:
                    return '7';
                case Keypad.Key.Digit_8:
                    return '8';
                case Keypad.Key.Digit_9:
                    return '9';
                case Keypad.Key.Down:
                    return 'D';
                case Keypad.Key.Home:
                    return 'E';
                case Keypad.Key.Left:
                    return 'X';
                case Keypad.Key.Lock:
                    return 'S';
                case Keypad.Key.Pound:
                    return '#';
                case Keypad.Key.Right:
                    return 'T';
                case Keypad.Key.Star:
                    return '*';
                case Keypad.Key.Unlock:
                    return 'N';
                case Keypad.Key.Up:
                    return 'U';
                default:
                    return (char)0;
            }
        }

        public static bool EnqueueToken(Key Key, KeyEngine Engine)
        {
            char chr = GetToken(Key);
            if(chr != (char)0)
               Engine.EnqueueKey(chr);
            else
                return false;

            return true;
        }

        private static void EnqueueChar(char ControlDigit, uint Presses, Queue<char> Queue, bool Lowercase = false)
        {
            if (Lowercase)
                Queue.Enqueue('#');

            for (int i = 0; i < Presses; i++)
                Queue.Enqueue(ControlDigit);

            if (Lowercase)
                Queue.Enqueue('#');

            Queue.Enqueue('D');
        }

        private static bool QueueAsciiToken(char Character, Queue<char> Queue)
        {
            switch (Character)
            {
                case '1':
                    EnqueueChar('1', 1, Queue);
                    return true;
                case 'A':
                case 'a':
                    EnqueueChar('2', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'B':
                case 'b':
                    EnqueueChar('2', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'C':
                case 'c':
                    EnqueueChar('2', 3, Queue, Char.IsLower(Character));
                    return true;
                case 'Ä':
                case 'ä':
                    EnqueueChar('2', 6, Queue, Char.IsLower(Character));
                    return true;
                case '2':
                    EnqueueChar('2', 12, Queue);
                    return true;
                case 'D':
                case 'd':
                    EnqueueChar('3', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'E':
                case 'e':
                    EnqueueChar('3', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'F':
                case 'f':
                    EnqueueChar('3', 3, Queue, Char.IsLower(Character));
                    return true;
                case '3':
                    EnqueueChar('3', 9, Queue);
                    return true;
                case 'G':
                case 'g':
                    EnqueueChar('4', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'H':
                case 'h':
                    EnqueueChar('4', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'I':
                case 'i':
                    EnqueueChar('4', 3, Queue, Char.IsLower(Character));
                    return true;
                case '4':
                    EnqueueChar('4', 8, Queue);
                    return true;
                case 'J':
                case 'j':
                    EnqueueChar('5', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'K':
                case 'k':
                    EnqueueChar('5', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'L':
                case 'l':
                    EnqueueChar('5', 3, Queue, Char.IsLower(Character));
                    return true;
                case '5':
                    EnqueueChar('5', 5, Queue);
                    return true;
                case 'M':
                case 'm':
                    EnqueueChar('6', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'N':
                case 'n':
                    EnqueueChar('6', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'O':
                case 'o':
                    EnqueueChar('6', 3, Queue, Char.IsLower(Character));
                    return true;
                case 'Ö':
                case 'ö':
                    EnqueueChar('6', 5, Queue, Char.IsLower(Character));
                    return true;
                case '6':
                    EnqueueChar('6', 11, Queue);
                    return true;
                case 'P':
                case 'p':
                    EnqueueChar('7', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'Q':
                case 'q':
                    EnqueueChar('7', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'R':
                case 'r':
                    EnqueueChar('7', 3, Queue, Char.IsLower(Character));
                    return true;
                case 'S':
                case 's':
                    EnqueueChar('7', 4, Queue, Char.IsLower(Character));
                    return true;
                case 'ß':
                    EnqueueChar('7', 4, Queue);
                    EnqueueChar('7', 4, Queue);
                    return true;
                case '7':
                    EnqueueChar('7', 7, Queue);
                    return true;
                case 'T':
                case 't':
                    EnqueueChar('8', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'U':
                case 'u':
                    EnqueueChar('8', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'V':
                case 'v':
                    EnqueueChar('8', 3, Queue, Char.IsLower(Character));
                    return true;
                case 'Ü':
                case 'ü':
                    EnqueueChar('8', 4, Queue, Char.IsLower(Character));
                    return true;
                case '8':
                    EnqueueChar('8', 7, Queue);
                    return true;
                case 'W':
                case 'w':
                    EnqueueChar('9', 1, Queue, Char.IsLower(Character));
                    return true;
                case 'X':
                case 'x':
                    EnqueueChar('9', 2, Queue, Char.IsLower(Character));
                    return true;
                case 'Y':
                case 'y':
                    EnqueueChar('9', 3, Queue, Char.IsLower(Character));
                    return true;
                case 'Z':
                case 'z':
                    EnqueueChar('9', 4, Queue, Char.IsLower(Character));
                    return true;
                case '9':
                    EnqueueChar('9', 8, Queue);
                    return true;
                case ' ':
                    EnqueueChar('0', 1, Queue);
                    return true;
                case ',':
                    EnqueueChar('0', 2, Queue);
                    return true;
                case '(':
                    EnqueueChar('0', 3, Queue);
                    return true;
                case ')':
                    EnqueueChar('0', 4, Queue);
                    return true;
                case ':':
                    EnqueueChar('0', 5, Queue);
                    return true;
                case '.':
                    EnqueueChar('0', 6, Queue);
                    return true;
                case '-':
                    EnqueueChar('0', 7, Queue);
                    return true;
                case '!':
                    EnqueueChar('0', 8, Queue);
                    return true;
                case '&':
                    EnqueueChar('0', 9, Queue);
                    return true;
                case '@':
                    EnqueueChar('0', 10, Queue);
                    return true;
                case '+':
                    EnqueueChar('0', 11, Queue);
                    return true;
                case '_':
                    EnqueueChar('0', 12, Queue);
                    return true;
                case '*':
                    EnqueueChar('0', 13, Queue);
                    return true;
                case '#':
                    EnqueueChar('0', 14, Queue);
                    return true;
                case '0':
                    EnqueueChar('0', 15, Queue);
                    return true;
                default:
                    return false;
            }
        }

        public static Queue<char> GetTokens(string Message)
        {
            Queue<char> queue = new Queue<char>();

            foreach (char chr in Message)
            {
                if (!QueueAsciiToken(chr, queue))
                    return null;
            }

            return queue;
        }

        public static bool EnqueueTokens(string Message, KeyEngine Engine)
        {
            Queue<char> queue = GetTokens(Message);
            if (queue != null)
            {
                while (queue.Count > 0)
                    Engine.EnqueueKey(queue.Dequeue());

                return true;
            }
            else
                return false;
        }
    }
}
