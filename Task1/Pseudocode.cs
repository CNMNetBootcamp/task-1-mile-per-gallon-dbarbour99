//setup
single mileage=0
single miles=0
single gallons = 0

//input
miles = GET "How many miles did you travel?"
gallons = GET "How much gas did you use?"

//processing
mileage = miles/gallons

//output
PUT "You got " + mileage + " miles per gallon"
