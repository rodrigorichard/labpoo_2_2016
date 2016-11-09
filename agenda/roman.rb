class Integer
  @@roman_values_assoc = %w(i iv v ix x xl l xc x cd d cm m).zip([1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000]).reverse

  @@roman_values = @@roman_values_assoc.inject({}) { |h, (r,a)| h[r] = a; h }

  def roman
    return "-#{(-self).roman}" if self < 0
    return "" if self == 0
    @@roman_values_assoc.each do | (i, v) | return(i+(self-v).roman) if v <= self end
  end

  def Integer.roman(roman)
    last = roman[-1,1]
    roman.reverse.split('').inject(0) { | result, c |
      if @@roman_values[c] < @@roman_values[last]
        result -= @@roman_values[c]
      else
        last = c
        result += @@roman_values[c]
      end
    }
  end
end

def method_missing(method_id,*args)
 	Integer.roman(method_id.id2name)
end
