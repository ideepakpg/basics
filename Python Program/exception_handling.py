b=10

try:
    a=10/b
    print(a)
    print("try completed")

except ZeroDivisionError:
    print("Can't divided by Zero")

print("Program is completed")    