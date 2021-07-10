# typewriterbatch
A typewriter-style plugin for batch. Customize delay between characters printed to the screen.
It can be useful for loading menus or adding aesthetic to console utilities. The delay can be customized in milliseconds.

# How to use
```typewriter "Hello, World!" 100 y```

The above command will print "Hello, World!" with a 100 millisecond delay (1/10th of a second) and the 'y' flag will add a newline character to the end.

```typewriter (string) (delay time) (y/n newline)```

If y/n is not specified, a newline is added by default. The program will check to ensure the delay is a valid number and is not negative. I would not recommend using very large numbers. Here is a list of common delays:

100 - 1/10th a second

250 - 1/4 a second

500 - 1/2 a second

1000 - 1 second

5000 - 5 seconds

10000 - 10 seconds 


The program has a delay by putting the current thread to sleep, so it should still be able to respond to Ctrl+C, but further batch processing can't happen until the program finishes typing.
