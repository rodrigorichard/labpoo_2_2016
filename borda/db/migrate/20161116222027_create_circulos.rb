class CreateCirculos < ActiveRecord::Migration
  def change
    create_table :circulos do |t|
      t.float :raio

      t.timestamps null: false
    end
  end
end
