int D(char a, char b) {
    if (a == 'h' || a == 'w')
        return 1;

    if (a == b)
        return 0;
    else if (sound(a, b) == 1)
		return 1;
    else
        return 2;
}