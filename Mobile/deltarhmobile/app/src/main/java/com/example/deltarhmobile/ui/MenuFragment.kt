package com.example.deltarhmobile.ui

import android.os.Build
import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import androidx.annotation.RequiresApi
import com.example.deltarhmobile.NavigationHost
import com.example.deltarhmobile.R
import com.example.deltarhmobile.retrofit.api.UserAPI
import com.example.deltarhmobile.retrofit.config.NetworkConfig
import com.example.deltarhmobile.retrofit.config.SessionManager
import com.example.deltarhmobile.retrofit.model.LoggedUserInfo
import com.example.deltarhmobile.retrofit.model.UserModel
import com.example.deltarhmobile.retrofit.model.UserRequest
import com.example.deltarhmobile.retrofit.model.UserResponse
import com.google.android.material.textfield.TextInputEditText
import retrofit2.Call
import retrofit2.Response

class MenuFragment : Fragment() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {

        }
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        return inflater.inflate(R.layout.fragment_menu, container, false)
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        try {
            val userAPI: UserAPI = NetworkConfig.provideApi<UserAPI>(UserAPI::class.java, context)
            val call: Call<UserModel> = userAPI.carregarDados()
            val response: Response<UserModel> = call.execute()
            var responseBody = response.body()

            if(response.isSuccessful){
                val userName = view.findViewById<TextView>(R.id.text_username)
                if (responseBody != null) {
                    userName.text = responseBody.nome
                }
            }
        }catch (e : Exception){
            Log.d("Erro busca:", e.stackTraceToString())
        }

        val registrarPontoButton = view.findViewById<Button>(R.id.registrar_button)
        registrarPontoButton.setOnClickListener{
            (activity as NavigationHost).navigateTo(PontoFragment(), true)
        }

        //outros botoes

        val logoutButton = view.findViewById<Button>(R.id.logout_button)
        logoutButton.setOnClickListener{
            val sessionManager = SessionManager(context)
            sessionManager.removeToken()
            (activity as NavigationHost).navigateTo(LoginFragment(), false)
        }
    }

    companion object {

    }
}