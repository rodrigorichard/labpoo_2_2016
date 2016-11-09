fixed = File.open('enderecos.fix.csv','w')
File.open('enderecos.csv','r:iso-8859-1').each_line do |line|
  fixed << line if line.count(',') == 9
end
fixed.close