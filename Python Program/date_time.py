import datetime

#date and time
print(datetime.datetime.now())

#date only
print(datetime.date.today())

#In date/month/year order
now=datetime.datetime.now()

print(now.strftime("%d/%m/%Y"))

#any date
x=datetime.datetime(2023,1,25)

print(x)

#subtract date
x=datetime.datetime(2023,1,27)
y=datetime.datetime(2010,1,29)

dif=x-y
print(dif)