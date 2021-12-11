using System;

class Soundex {

	int sound(char a, char b) {
		int flag = 0, i;
		string[] equi_class = { "vow", "aeiouy", "bp", "ckq", "dt", "lr", "mn", "gj", "fpv", "sxz", "csz" };
		for (i = 0; i < 11; i++) {
			if (equi_class[i].Contains(a) && equi_class[i].Contains(b)) {
				flag = 1;
				break;
			}
		}
	
		if (flag == 1)
			return 1;

		return 0;
	}
}