Hiding in C#
============

A small demo of how one object can have two different values for the same member 
name, depending on how you refer to it.

In the example, we have a Food type, and a Fruit type. Food is the base class of
Fruit.

Food has two properties: Name, and VirtualName. Name is a regular string 
property, and VirtualName is another string property, but declared `virtual`. 
Fruit redeclares Name with the `new` keyword, and redeclares VirtualName with 
the `override` keyword.

We create a Fruit and set its Name and VirtualName; we then assign it to a 
second variable, of type Food. We then set Name and VirtualName on this second
variable.

Lastly we output Name and VirtualName on the Fruit, and on the same object but 
via the variable of type Food.

What we see is that Name is different depending whether you address it as a Food
or as a Fruit; meanwhile, VirtualName only exists once, and the value is the
same regardles of type.

As a side-note, it's worth pointing out that even if a base-class declares a 
member `virtual`, a derived class can *still* hide it by redeclaring it `new`.