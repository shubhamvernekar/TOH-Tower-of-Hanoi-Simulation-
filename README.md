# TOH-Tower-of-Hanoi-Simulation-
Tower of hanoi GUI simulator 
The Tower of Hanoi (also called the Tower of Brahma or Lucas' Tower,[1] and sometimes pluralised) is a mathematical game or puzzle. It consists of three rods, and a number of disks of different sizes which can slide onto any rod. The puzzle starts with the disks in a neat stack in ascending order of size on one rod, the smallest at the top, thus making a conical shape.

The objective of the puzzle is to move the entire stack to another rod, obeying the following rules:

    Only one disk must be moved at a time.
    Each move consists of taking the upper disk from one of the rods and sliding it onto another rod, on top of the other disks that may already be present on that rod.
    No disk may be placed on top of a smaller disk.
    
    Recursive Algorithm

    Label the stands Src, Intr, Dest.
    Let n be the total number of discs.
    Number the discs from 1 (smallest, topmost) to n (largest, bottommost). 

To move n discs from stand Src to stand Dest:

    Move n-1 plates from Src to Intr. This leaves plate #n alone on plate Src.
    Move plate #n from Src to Dest.
    Move n-1 plates from Intr to Dest so they sit on plate #n. 
    
    The above is a recursive algorithm: to carry out steps 1 and 3, apply the same algorithm again for n-1. The entire procedure is a finite number of steps, since at some point the algorithm will be required for n = 1. This step, moving a single plate from stand Src to stand Dest, is trivial.
