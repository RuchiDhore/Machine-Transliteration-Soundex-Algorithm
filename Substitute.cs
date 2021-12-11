int S(char a, char b) {
    if (a == b)
        return 0;
    else if (sound(a, b) == 1)
        return 1;
    else
        return 2;
}