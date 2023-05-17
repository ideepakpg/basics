def ghoul_probability(humans: int, ghoul_c: int, ghoul_b: int, ghoul_a: int, ghoul_s: int, n: str) -> float:
    total_people = humans + ghoul_c + ghoul_b + ghoul_a + ghoul_s
    if n == "C":
        ghouls = ghoul_c
    elif n == "B":
        ghouls = ghoul_b
    elif n == "A":
        ghouls = ghoul_a
    elif n == "S":
        ghouls = ghoul_s
    else:
        return "Invalid Ghoul class"
    probability = ghouls / total_people
    return probability