'''
class Fraction:
    def __init__(self, num: int, den: int):
        self.num = num
        self.den = den

    def __str__(self):
        return f"{self.num}/{self.den}"

    def __add__(self, other):
        new_num = self.num * other.den + self.den * other.num
        new_den = self.den * other.den
        return Fraction(new_num, new_den)

    def __sub__(self, other):
        new_num = self.num * other.den - self.den * other.num
        new_den = self.den * other.den
        return Fraction(new_num, new_den)

    def __mul__(self, other):
        new_num = self.num * other.num
        new_den = self.den * other.den
        return Fraction(new_num, new_den)

    def __truediv__(self, other):
        new_num = self.num * other.den
        new_den = self.den * other.num
        return Fraction(new_num, new_den)

    def simplify(self):
        gcd = Fraction.gcd(self.num, self.den)
        self.num //= gcd
        self.den //= gcd

    @staticmethod
    def gcd(a: int, b: int):
        while b:
            a, b = b, a % b
        return a

a = Fraction(1, 2)
print(a)
b = Fraction(9, 12)
print(a + b)


class Student:
  def __init__(self, name, age, mark):
    self.name = name
    self.age = age
    self.mark = mark

  def __str__(self):
    return f"Student: {self.name}, Age: {self.age}, Mark: {self.mark}"



# Ngày tiếp theo, but still bugs
import datetime
import sys
for line in sys.stdin.readlines():
    d, m, y = map(int, input().split("/"))
    x = datetime.date(y, m, d)
    x = x + datetime.timedelta(1)
    print("%d/%d/%d" %(x.day, x.month, x.year))

'''

