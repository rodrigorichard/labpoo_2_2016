class Circulo < ActiveRecord::Base
  validates_presence_of :raio
  validates :raio, :numericality => { :greater_than => 10 }
end
