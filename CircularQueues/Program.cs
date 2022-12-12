using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array=new int[5];

        public Program()
        {
            //Intializing the values of the variables REAR and FRONT to -1 to indicate that the queue is initally empty
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            //this statemenet checks for the overflow condition
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\n Queue overflow\n");
                return;
            }
            //this following statement checks wether the queue is empty. if the queue is empty,
            //then teh value of the REAR and FRONT variablesis set to 0

            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                //if REAR is at the last position of the array, then the value of 
                //REAR is set to 0 that corresponds to the first position of the array.

                if (REAR == max - 1)
                    REAR = 0;
                else
                    //if REAR is not at the last position, then its value is incremented by one
                    REAR = REAR + 1;
            }
            //Once the position of REAR is determined, the element is added at its proper place
            queue_array[REAR] = element;
        }

        public void remove()
        {
                //checks wheather the queue is empty

                if (FRONT == -1)
                {
                    Console.WriteLine("Queue underflow\n");
                    return ;
                }
                Console.WriteLine("\n The Element deleted from the queue is : " + queue_array[FRONT] + "\n");
                
                //check if the queue has one element
                if (FRONT == REAR)
                {
                    FRONT = -1;
                    REAR = -1;

                }
                else
                {
                    //if the element to be deleted is at the last position of the array,
                    //then the value of FRONT is set to 0 i.e to the first element if the array
                    
                    if (FRONT == max -1)
                        FRONT = 0;
                    else 
                        //FRONT is incremented by one if it is not the first element of array

                    FRONT = REAR +1;
                }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            //Check if the queue is empty

            if (FRONT == -1)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            Console.WriteLine("\n Element in the queue are ...................\n");
            if (FRONT_position <= REAR_position)
            {
                //travers the queue till the last element present in an array

                while (FRONT_position<=REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                //traverses the queue till the last position of the array 
                while (FRONT_position<= max -1)
                {
                    Console.Write(queue_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                //set the FRONT position to the first element of the array 

                FRONT_position = 0;

                //traverse the array till the last element present in the queue

                while(FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        
       
    }
}
