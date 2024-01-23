package com.example.lab1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;


public class MainActivity extends AppCompatActivity {

    EditText editTextHoTen, editTextSoDienThoai;
    String hoTen, soDienThoai, queQuan;
    Spinner spinnerQueQuan;
    Button buttonAdd;
    ListView listViewDanhSach;
    RadioButton radioButtonMale, radioButtonFemale;
    RadioGroup radioGroupGender;
    ArrayList<CheckBox> listCheckBoxHobbies = new ArrayList<CheckBox>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editTextHoTen = findViewById(R.id.editTextHoTen);
        editTextSoDienThoai = findViewById(R.id.editTextSoDienThoai);
        spinnerQueQuan = findViewById(R.id.spinnerQueQuan);
        buttonAdd = findViewById(R.id.buttonAdd);
        listViewDanhSach = findViewById(R.id.listViewDanhSach);
        radioGroupGender = findViewById(R.id.radioGroupGender);

        listCheckBoxHobbies.add(findViewById(R.id.checkboxFootball));
        listCheckBoxHobbies.add(findViewById(R.id.checkboxSwimming));
        listCheckBoxHobbies.add(findViewById(R.id.checkboxReading));

        // The Spinner contains informations of provinces
        spinnerQueQuan.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id)
            {
                String item = parent.getItemAtPosition(position).toString();
                queQuan = parent.getItemAtPosition(position).toString();
                Toast.makeText(MainActivity.this, "Selected Item: " + item, Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });

        ArrayList<String> arrayList = new ArrayList<>();
        arrayList.add("Hà Nội");
        arrayList.add("Thái Bình");
        arrayList.add("Hà Tĩnh");
        arrayList.add("Bắc Ninh");
        arrayList.add("Phú Thọ");
        arrayList.add("Bắc Giang");
        arrayList.add("Quảng Ninh");
        arrayList.add("Tuyên Quang");

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_item, arrayList);

        adapter.setDropDownViewResource(android.R.layout.select_dialog_singlechoice);
        spinnerQueQuan.setAdapter(adapter);

        //The listView shows the informations of people
        ArrayList<String> arrayInformationList = new ArrayList<>();
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(this,
                androidx.constraintlayout.widget.R.layout.support_simple_spinner_dropdown_item,
                arrayInformationList);


        buttonAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                int selectedGenderId = radioGroupGender.getCheckedRadioButtonId();
                String selectedGenderText = "";
                if (selectedGenderId != -1) {
                    RadioButton selectedRadioButton = findViewById(selectedGenderId);
                    selectedGenderText = selectedRadioButton.getText().toString();
                    // Use the selected text as needed
                } else {
                    // Handle the case when no radio button is selected
                }

                String hobbies = "";

                if (((CheckBox)findViewById(R.id.checkboxFootball)).isChecked())
                {
                    hobbies += "bóng đá, ";
                }

                if (((CheckBox)findViewById(R.id.checkboxSwimming)).isChecked())
                {
                    hobbies += "bơi, ";
                }

                if (((CheckBox)findViewById(R.id.checkboxReading)).isChecked())
                {
                    hobbies += "đọc sách, ";
                }

                String infor = String.format("%s, %s, %s, %s %s",
                        editTextHoTen.getText().toString(),
                        editTextSoDienThoai.getText().toString(),
                        queQuan,
                        hobbies,
                        selectedGenderText);
                arrayInformationList.add(infor);
                listViewDanhSach.setAdapter(arrayAdapter);
            }
        });

    }



}