class CreatePessoas < ActiveRecord::Migration
  def change
    create_table :pessoas do |t|
      t.string :nome
      t.string :telefone
      t.datetime :data_nascimento
      t.text :observacoes

      t.timestamps null: false
    end
  end
end
