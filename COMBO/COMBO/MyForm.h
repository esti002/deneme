#pragma once
#define _NO_WARNINGS_
namespace COMBO {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// MyForm için özet
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Oluþturucu kodunu buraya ekle
			//
		}

	protected:
		/// <summary>
		///Kullanýlan tüm kaynaklarý temizleyin.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ panel1;
	private: System::Windows::Forms::Button^ homePageButton;
	private: System::Windows::Forms::Button^ closeButton;
	private: System::Windows::Forms::Button^ button2;


	protected:

	private:
		/// <summary>
		///Gerekli tasarýmcý deðiþkeni.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Tasarýmcý desteði için gerekli metot - bu metodun 
		///içeriðini kod düzenleyici ile deðiþtirmeyin.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm::typeid));
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->closeButton = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->homePageButton = (gcnew System::Windows::Forms::Button());
			this->panel1->SuspendLayout();
			this->SuspendLayout();
			// 
			// panel1
			// 
			this->panel1->BackColor = System::Drawing::SystemColors::ControlDark;
			this->panel1->Controls->Add(this->closeButton);
			this->panel1->Controls->Add(this->button2);
			this->panel1->Controls->Add(this->homePageButton);
			this->panel1->Location = System::Drawing::Point(0, 0);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(70, 700);
			this->panel1->TabIndex = 0;
			// 
			// closeButton
			// 
			this->closeButton->BackColor = System::Drawing::Color::Transparent;
			this->closeButton->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"closeButton.BackgroundImage")));
			this->closeButton->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Zoom;
			this->closeButton->FlatAppearance->BorderSize = 0;
			this->closeButton->FlatAppearance->MouseOverBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(0)), static_cast<System::Int32>(static_cast<System::Byte>(0)));
			this->closeButton->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->closeButton->Location = System::Drawing::Point(0, 630);
			this->closeButton->Name = L"closeButton";
			this->closeButton->Size = System::Drawing::Size(70, 70);
			this->closeButton->TabIndex = 2;
			this->closeButton->UseVisualStyleBackColor = false;
			this->closeButton->Click += gcnew System::EventHandler(this, &MyForm::closeButton_Click);
			// 
			// button2
			// 
			this->button2->BackColor = System::Drawing::Color::Transparent;
			this->button2->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Center;
			this->button2->FlatAppearance->BorderSize = 0;
			this->button2->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->button2->Location = System::Drawing::Point(0, 177);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(70, 70);
			this->button2->TabIndex = 1;
			this->button2->Text = L"button2";
			this->button2->UseVisualStyleBackColor = false;
			// 
			// homePageButton
			// 
			this->homePageButton->BackColor = System::Drawing::Color::Transparent;
			this->homePageButton->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Zoom;
			this->homePageButton->FlatAppearance->BorderSize = 0;
			this->homePageButton->FlatAppearance->MouseOverBackColor = System::Drawing::Color::Blue;
			this->homePageButton->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->homePageButton->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"homePageButton.Image")));
			this->homePageButton->Location = System::Drawing::Point(0, 0);
			this->homePageButton->Name = L"homePageButton";
			this->homePageButton->Size = System::Drawing::Size(70, 70);
			this->homePageButton->TabIndex = 1;
			this->homePageButton->UseVisualStyleBackColor = false;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1170, 700);
			this->Controls->Add(this->panel1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->panel1->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void closeButton_Click(System::Object^ sender, System::EventArgs^ e) {
		Close();
	}
private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {

}
};
}
