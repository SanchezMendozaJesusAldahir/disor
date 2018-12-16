#include <iostream>
#include <stdlib.h>
#include "CifradoMensajePlano.h"
#include "GruposInversos.h"
#pragma once

namespace Cesar {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;
	/// <summary>
	/// Resumen de Cesar
	/// </summary>
	public ref class Cesar : public System::Windows::Forms::Form
	{
	public:
		Cesar(void)
		{
			InitializeComponent();
			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		~Cesar()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  textBox1;

	private: System::Windows::Forms::NumericUpDown^  numericUpDown1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::RichTextBox^  richTextBox1;
	private: System::Windows::Forms::RichTextBox^  richTextBox2;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Panel^  panel1;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::NumericUpDown^  numericUpDown2;
	private: System::Windows::Forms::RichTextBox^  richTextBox3;
	private: System::Windows::Forms::Panel^  panel2;
	private: System::Windows::Forms::Panel^  panel3;
	protected:

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->numericUpDown1 = (gcnew System::Windows::Forms::NumericUpDown());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->richTextBox1 = (gcnew System::Windows::Forms::RichTextBox());
			this->richTextBox2 = (gcnew System::Windows::Forms::RichTextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->numericUpDown2 = (gcnew System::Windows::Forms::NumericUpDown());
			this->richTextBox3 = (gcnew System::Windows::Forms::RichTextBox());
			this->panel2 = (gcnew System::Windows::Forms::Panel());
			this->panel3 = (gcnew System::Windows::Forms::Panel());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown1))->BeginInit();
			this->panel1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown2))->BeginInit();
			this->panel2->SuspendLayout();
			this->panel3->SuspendLayout();
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(102, 45);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(279, 20);
			this->textBox1->TabIndex = 0;
			this->textBox1->KeyUp += gcnew System::Windows::Forms::KeyEventHandler(this, &Cesar::textBox1_KeyUp);
			// 
			// numericUpDown1
			// 
			this->numericUpDown1->Location = System::Drawing::Point(90, 32);
			this->numericUpDown1->Maximum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 31, 0, 0, 0 });
			this->numericUpDown1->Name = L"numericUpDown1";
			this->numericUpDown1->Size = System::Drawing::Size(82, 20);
			this->numericUpDown1->TabIndex = 2;
			this->numericUpDown1->ValueChanged += gcnew System::EventHandler(this, &Cesar::numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(37, 45);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(47, 13);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Mensaje";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(2, 34);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(82, 13);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Desplazamiento";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(3, 62);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(40, 13);
			this->label3->TabIndex = 5;
			this->label3->Text = L"Cifrado";
			// 
			// richTextBox1
			// 
			this->richTextBox1->Location = System::Drawing::Point(3, 87);
			this->richTextBox1->Name = L"richTextBox1";
			this->richTextBox1->Size = System::Drawing::Size(219, 173);
			this->richTextBox1->TabIndex = 6;
			this->richTextBox1->Text = L"";
			// 
			// richTextBox2
			// 
			this->richTextBox2->Location = System::Drawing::Point(3, 87);
			this->richTextBox2->Name = L"richTextBox2";
			this->richTextBox2->Size = System::Drawing::Size(250, 173);
			this->richTextBox2->TabIndex = 7;
			this->richTextBox2->Text = L"";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(13, 27);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(42, 13);
			this->label4->TabIndex = 8;
			this->label4->Text = L"Inverso";
			// 
			// panel1
			// 
			this->panel1->Controls->Add(this->label6);
			this->panel1->Controls->Add(this->label5);
			this->panel1->Controls->Add(this->numericUpDown2);
			this->panel1->Controls->Add(this->richTextBox3);
			this->panel1->Location = System::Drawing::Point(502, 94);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(263, 263);
			this->panel1->TabIndex = 9;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(12, 71);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(42, 13);
			this->label6->TabIndex = 3;
			this->label6->Text = L"Inverso";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(12, 32);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(56, 13);
			this->label5->TabIndex = 2;
			this->label5->Text = L"Grupos de";
			// 
			// numericUpDown2
			// 
			this->numericUpDown2->Location = System::Drawing::Point(90, 30);
			this->numericUpDown2->Name = L"numericUpDown2";
			this->numericUpDown2->Size = System::Drawing::Size(120, 20);
			this->numericUpDown2->TabIndex = 1;
			this->numericUpDown2->ValueChanged += gcnew System::EventHandler(this, &Cesar::numericUpDown2_ValueChanged);
			// 
			// richTextBox3
			// 
			this->richTextBox3->Location = System::Drawing::Point(3, 87);
			this->richTextBox3->Name = L"richTextBox3";
			this->richTextBox3->Size = System::Drawing::Size(257, 173);
			this->richTextBox3->TabIndex = 0;
			this->richTextBox3->Text = L"";
			// 
			// panel2
			// 
			this->panel2->Controls->Add(this->richTextBox2);
			this->panel2->Controls->Add(this->label4);
			this->panel2->Location = System::Drawing::Point(240, 94);
			this->panel2->Name = L"panel2";
			this->panel2->Size = System::Drawing::Size(256, 263);
			this->panel2->TabIndex = 10;
			// 
			// panel3
			// 
			this->panel3->Controls->Add(this->richTextBox1);
			this->panel3->Controls->Add(this->label3);
			this->panel3->Controls->Add(this->numericUpDown1);
			this->panel3->Controls->Add(this->label2);
			this->panel3->Location = System::Drawing::Point(12, 94);
			this->panel3->Name = L"panel3";
			this->panel3->Size = System::Drawing::Size(222, 263);
			this->panel3->TabIndex = 11;
			// 
			// Cesar
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(765, 403);
			this->Controls->Add(this->panel3);
			this->Controls->Add(this->panel2);
			this->Controls->Add(this->panel1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Name = L"Cesar";
			this->Text = L"Cesar";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown1))->EndInit();
			this->panel1->ResumeLayout(false);
			this->panel1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown2))->EndInit();
			this->panel2->ResumeLayout(false);
			this->panel2->PerformLayout();
			this->panel3->ResumeLayout(false);
			this->panel3->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
private:string convertir(String^ cad){
	string os;
	using namespace System::Runtime::InteropServices;
	const char* chars = (const char*)(Marshal::StringToHGlobalAnsi(cad)).ToPointer();
	os = chars;
	Marshal::FreeHGlobal(IntPtr((void*)chars));
	return os;
}			

private: System::Void textBox1_KeyUp(System::Object^  sender, System::Windows::Forms::KeyEventArgs^  e) {
	CifradoMensajePlano cmp;
	GruposInversos gi;
	richTextBox1->Text = gcnew String(cmp.mensajeCifrado(convertir(textBox1->Text), (int)numericUpDown1->Value, "").c_str());
	richTextBox2->Text = gcnew String(gi.inverso(convertir(textBox1->Text), "").c_str());
	richTextBox3->Text = gcnew String(gi.invertir_en_grupos(convertir(textBox1->Text), int::Parse(numericUpDown2->Value.ToString()), "").c_str());
}

private: System::Void numericUpDown1_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
	CifradoMensajePlano cmp;
	richTextBox1->Text = gcnew String(cmp.mensajeCifrado(convertir(textBox1->Text), (int)numericUpDown1->Value, "").c_str());
}
private: System::Void numericUpDown2_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
	GruposInversos gi;
	richTextBox3->Text = gcnew String(gi.invertir_en_grupos(convertir(textBox1->Text), (int)numericUpDown2->Value, "").c_str());
}
};
}
