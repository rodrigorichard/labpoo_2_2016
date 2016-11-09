class MaquinaPilha
  

  
  def initialize(instrucoes)
    @stack = []
    @instrucoes = instrucoes
    @instrucoes.each do |i|
      self.send(i[0].to_sym,i[1])
    end
  end
  
  
  def add(v)
    e1 = @stack.pop
    e2 = @stack.pop
    @stack.push(e1 + e2)
  end
  
  def push(v)
    @stack.push(v)
  end
  
  def print(v)
    puts @stack.first
  end
  
  def sub(v)
    e1 = @stack.pop
    e2 = @stack.pop
    @stack.push(e1 - e2)
    
  end
  
  def xpto(v)
    puts "aslkdfjaskldjalksjd"
  end
  
end


ins = [["xpto",10],["push",5],["push",5],["add",nil],["push",2],["sub",nil],["print",nil]]
MaquinaPilha.new(ins)
