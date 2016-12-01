require 'test_helper'

class CirculosControllerTest < ActionController::TestCase
  setup do
    @circulo = circulos(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:circulos)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create circulo" do
    assert_difference('Circulo.count') do
      post :create, circulo: { raio: @circulo.raio }
    end

    assert_redirected_to circulo_path(assigns(:circulo))
  end

  test "should show circulo" do
    get :show, id: @circulo
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @circulo
    assert_response :success
  end

  test "should update circulo" do
    patch :update, id: @circulo, circulo: { raio: @circulo.raio }
    assert_redirected_to circulo_path(assigns(:circulo))
  end

  test "should destroy circulo" do
    assert_difference('Circulo.count', -1) do
      delete :destroy, id: @circulo
    end

    assert_redirected_to circulos_path
  end
end
