module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0
    then 0
    elif n = 1
    then 1
    elif n = 2
    then 1
    else tribn (n-1) + tribn (n-2) + tribn (n-3)
    

// Problem 2
let tribn2 n =
    // write your code here
    0

// Problem 3
let rec last (lst:int list) =
    // write your code here
   // match lst with
    //|[x]->x
    //|_::tail -> last tail
    if lst.Tail.IsEmpty
    then List.head lst
    else last (List.tail lst)

// Problem 4
let fourth (lst:int list) =
    // write your code here
    if lst.IsEmpty || lst.Tail.IsEmpty || lst.Tail.Tail.IsEmpty || lst.Tail.Tail.Tail.IsEmpty
    then 0
    else lst.Tail.Tail.Tail.Head

    

// Problem 5
let everyfourth (lst:int list) =
    // write your code here
    if lst.IsEmpty || lst.Tail.IsEmpty || lst.Tail.Tail.IsEmpty || lst.Tail.Tail.Tail.IsEmpty
    then []
    else [fourth lst; fourth(lst.Tail.Tail.Tail.Tail); fourth(lst.Tail.Tail.Tail.Tail.Tail.Tail.Tail.Tail)]
    
    

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    if n = 0
    then []
    else List.head lst :: (take n (List.tail lst))
    

// Problem 7
let rec drop n (lst:int list) =
    //if n = 0
    //then List.tail lst
    //else drop (n (List.tail lst))
    []
   
