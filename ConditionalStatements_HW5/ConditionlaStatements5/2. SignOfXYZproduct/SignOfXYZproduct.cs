using System;

class SignOfXYZproduct
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers with negative and positive signs:");
		Console.WriteLine("Please enter 1st number:");
	    int FirstNumber=int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 2nd number:");
	    int SecondNumber=int.Parse(Console.ReadLine());
	    Console.WriteLine("Please enter 3rd number:");
	    int ThirdNumber=int.Parse(Console.ReadLine());
		int XYZproduct=FirstNumber*SecondNumber*ThirdNumber;
  if ((FirstNumber!=0)&&(SecondNumber!=0)&&(ThirdNumber!=0))
  {
    	if (FirstNumber>0)
		{
			if (SecondNumber>0)
				{ 
					if (ThirdNumber>0)
                        {
						Console.WriteLine("The product of 3 entered numbers is with '+' sign: {0}", XYZproduct);
                        }
					else
                        {
                            if (ThirdNumber<0)
                                {
						        Console.WriteLine("The product of 3 entered numbers is with '-' sign: {0}", XYZproduct);
				                }
                        }
                }  
			else 
                {
                if (SecondNumber<0)
				    {      
					if (ThirdNumber>0)
                        {
						Console.WriteLine("The product of 3 enter numbers is with '-' sign: {0}", XYZproduct);
                        }
					else
                        {
                        if (ThirdNumber<0)
                            {
						    Console.WriteLine("The product of 3 enter numbers is with '+' sign: {0}", XYZproduct);
				            }
                        }
                    }
                }
        }
	    else
        {
            if (FirstNumber<0)
		    {  
			    if (SecondNumber>0)
					{
					    if (ThirdNumber>0)
                            {
						    Console.WriteLine("The product of 3 enter numbers is with '-' sign: {0}", XYZproduct);
                            }
					    else 
                            {
                                if (ThirdNumber<0)
                                    {
						            Console.WriteLine("The product of 3 enter numbers is with '+' sign: {0}", XYZproduct);
                                    }
				            }
                    }

			    else
                    {
                        if (SecondNumber<0)
				            {
					            if (ThirdNumber<0)
                                    {
						             Console.WriteLine("The product of 3 enter numbers is with '-' sign: {0}", XYZproduct);
                                    }
					            else
                                    { 
                                        if (ThirdNumber>0)
                                            {
						                    Console.WriteLine("The product of 3 enter numbers is with '+' sign: {0}", XYZproduct);
                                            }
                                    }
                            }
				    }
		    }
        }
    }

	  else
        {
            if ((FirstNumber==0)||(SecondNumber==0)||(ThirdNumber==0))
                {
                Console.WriteLine("The product of 3 enter numbers is ZERO: {0}", XYZproduct);
                }
        }
	  
    }
}
