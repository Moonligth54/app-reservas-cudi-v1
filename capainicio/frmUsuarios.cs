//using System;
//using System.Drawing;
//using System.Windows.Forms;
//using AForge.Video;
//using AForge.Video.DirectShow;
//using ZXing;
//using capanegocio;
//using capaentidad;

//namespace capainicio
//{
//    public partial class frmUsuarios : Form
//    {
//        private CN_Persona objCN_Persona = new CN_Persona();
//        private FilterInfoCollection misDispositivos;
//        private VideoCaptureDevice miCamara;
//        private BarcodeReader lectorPDF;

//        public frmUsuarios()
//        {
//            InitializeComponent();

//            lectorPDF = new BarcodeReader
//            {
//                AutoRotate = true,
//                Options = new ZXing.Common.DecodingOptions
//                {
//                    PossibleFormats = new[] { BarcodeFormat.PDF_417 },
//                    TryHarder = true
//                }
//            };
//        }

//        private void frmUsuarios_Load(object sender, EventArgs e)
//        {
//            CargarGrilla();
//            CargarCarreras();
//            ObtenerCamaras();
//        }

//        private void CargarGrilla()
//        {
//            dataGridView1.DataSource = objCN_Persona.Listar();
//        }

//        private void CargarCarreras()
//        {
//        }

//        private void ObtenerCamaras()
//        {
//            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
//            cboCamaras.Items.Clear();

//            if (misDispositivos.Count > 0)
//            {
//                foreach (FilterInfo dispositivo in misDispositivos)
//                {
//                    cboCamaras.Items.Add(dispositivo.Name);
//                }
//                cboCamaras.SelectedIndex = 0;
//            }
//        }

//        private void btnAgregar_Click(object sender, EventArgs e)
//        {
//            pnlRegistro.Visible = !pnlRegistro.Visible;
//            LimpiarCampos();
//            if (!pnlRegistro.Visible)
//            {
//                DetenerCamara();
//            }
//        }

//        private void btnEscanearDNI_Click(object sender, EventArgs e)
//        {
//            if (miCamara != null && miCamara.IsRunning)
//            {
//                DetenerCamara();
//                btnEscanearDNI.Text = "Iniciar Cámara";
//            }
//            else
//            {
//                IniciarCamara();
//                btnEscanearDNI.Text = "Detener Cámara";
//            }
//        }

//        private void IniciarCamara()
//        {
//            if (cboCamaras.Items.Count == 0)
//            {
//                MessageBox.Show("No se detectó ninguna cámara disponible.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            miCamara = new VideoCaptureDevice(misDispositivos[cboCamaras.SelectedIndex].MonikerString);
//            miCamara.NewFrame += new NewFrameEventHandler(CapturandoFotograma);
//            miCamara.Start();
//        }

//        private void CapturandoFotograma(object sender, NewFrameEventArgs eventArgs)
//        {
//            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();

//            if (picCamara.Image != null)
//            {
//                picCamara.Image.Dispose();
//            }
//            picCamara.Image = (Bitmap)eventArgs.Frame.Clone();

//            try
//            {
//                Result resultado = lectorPDF.Decode(imagen);
//                if (resultado != null)
//                {
//                    this.Invoke(new MethodInvoker(delegate ()
//                    {
//                        ParsearPDF417(resultado.Text);
//                        DetenerCamara();
//                        btnEscanearDNI.Text = "Iniciar Cámara";
//                    }));
//                }
//            }
//            catch
//            {
//            }
//            finally
//            {
//                imagen.Dispose();
//            }
//        }

//        private void textEscaneoDNI_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                e.SuppressKeyPress = true; 
//                ParsearPDF417(textEscaneoDNI.Text); 
//                textEscaneoDNI.Clear(); 
//            }
//        }

//        private void ParsearPDF417(string rawData)
//        {
//            if (string.IsNullOrWhiteSpace(rawData)) return;

//            string[] datos = rawData.Split('@');

//            if (datos.Length >= 5)
//            {
//                txtApellido.Text = NormalizarTexto(datos[1]); 
//                txtNombre.Text = NormalizarTexto(datos[2]);  
//                txtDNI.Text = datos[4].Trim();                
//            }
//            else
//            {
//                datos = rawData.Split(',');
//                if (datos.Length >= 3)
//                {
//                    txtApellido.Text = NormalizarTexto(datos[0]);
//                    txtNombre.Text = NormalizarTexto(datos[1]);
//                    txtDNI.Text = datos[2].Trim();
//                }
//            }
//        }

//        private string NormalizarTexto(string texto)
//        {
//            if (string.IsNullOrWhiteSpace(texto)) return string.Empty;
//            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.Trim().ToLower());
//        }

//        private void btnGuardar_Click(object sender, EventArgs e)
//        {
//            string mensaje;
//            personas nuevoAlumno = new personas()
//            {
//                dni = txtDNI.Text.Trim(),
//                nombre = txtNombre.Text.Trim(),
//                apellido = txtApellido.Text.Trim(),
//                id_carrera = cboCarrera.SelectedValue != null ? Convert.ToInt32(cboCarrera.SelectedValue) : (int?)null
//            };

//            bool resultado = objCN_Persona.Registrar(nuevoAlumno, out mensaje);

//            if (resultado)
//            {
//                MessageBox.Show("Alumno registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LimpiarCampos();
//                DetenerCamara();
//                pnlRegistro.Visible = false;
//                CargarGrilla();
//            }
//            else
//            {
//                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LimpiarCampos()
//        {
//            textEscaneoDNI.Clear();
//            txtDNI.Clear();
//            txtNombre.Clear();
//            txtApellido.Clear();
//            if (cboCarrera.Items.Count > 0) cboCarrera.SelectedIndex = 0;
//        }

//        private void DetenerCamara()
//        {
//            if (miCamara != null && miCamara.IsRunning)
//            {
//                miCamara.SignalToStop();
//                miCamara.WaitForStop(); 
//                miCamara = null;
//            }
//            if (picCamara.Image != null)
//            {
//                picCamara.Image.Dispose();
//                picCamara.Image = null;
//            }
//        }

//        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            DetenerCamara();
//        }
//    }
//}