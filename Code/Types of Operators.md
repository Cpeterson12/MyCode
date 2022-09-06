Types of Operators

--Arithmetic--

+ : Addition (duh)
you can even add strings together ex: ("Hello" + "world")

- : Subtract (crazy)
7.3 -2.1 = 5.2

* : Multiplication 3 * 5 = 15

/ : Division 15 / 3 = 5

++ = Increment (adds one to a value)
    ex:   int $num = 13;
          $num++; //num is now 14

-- : Decrament (does the opposite to Increment)

% : Modulus  (division, but only the remainder.)
       13 % 5 = 3 (top part of the remainder fraction)
       13 / 5 = 2 

^ : Power (Exponent)
3 ^ 2

--Assignment--

= : Assignment (from right to left)
                int $num = 5;

+= : Adds value to a variable and reassign to the variable
       int $num = 0;
       $num = $num + 10;
   or  $num += 10;

-= : Subract the value and reassign the variable

*= : Multiply the value and reassign it

/= : Divide the value and then reassign

%= Modulus and reassign

^= Exponent and reassign


--Comparison--
Returns True or False : 1 or 0

== : Equal to 
3 == 5 will give a 0 because it is false. 
3 == 3 will give a 1 because it is true.

!= : Not equal to
3 != 5 will give a 1 because it is true
3 != 3 will give a 0 because it is false

> : greater than
< : Less than

>= Greater than or equal to
<= Less than or eqal to


--Logical--
Returns True or False : 1 or 0

&& : And
((3 >= 4) && (5 > 2)); Will give us a value of 0.
 because one of these is false.

|| : Or
((3 >= 4) || (5 > 2)); will give a 1 because one 
of them is true.

! : Not
(!(3 >= 4)) will give a 1 because it does the opposite.