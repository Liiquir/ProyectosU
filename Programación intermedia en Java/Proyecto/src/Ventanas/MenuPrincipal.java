/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package Ventanas;

/**
 *
 * @author josue
 */
import Clases.ArrayCliente;
import Clases.ArrayConversiones;
import Clases.Cliente;
import Clases.Conversion;
import Clases.ConversionNueva;
import Clases.Equivalencias;
import java.awt.event.KeyEvent;
import Clases.EquivalenciasNuevas;
import Clases.InformeConversiones;
import java.awt.HeadlessException;
import java.awt.event.KeyAdapter;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.text.DecimalFormat;
import java.util.StringTokenizer;
import javax.swing.JOptionPane;
import javax.swing.RowFilter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableRowSorter;

public class MenuPrincipal extends javax.swing.JFrame {

    Cliente cliente;
    ArrayCliente arrayCliente;
    InformeConversiones informeConversiones;
    ArrayConversiones arrayConversiones;
    EquivalenciasNuevas NuevosDatos;
    Conversion convertidor;
    ConversionNueva NuevaConversion;
    DefaultTableModel modelo;
    int clic_tabla;
    private String ruta_txt = "Clientes.txt";
    private String ruta_txt1 = "Informes.txt";
    TableRowSorter trs;

    public MenuPrincipal() {
        initComponents();
        Equivalencias datos = new Equivalencias();
        NuevosDatos = new EquivalenciasNuevas(datos.getDescripcionMonedas(), datos.getTablaConversiones());
        convertidor = new Conversion(NuevosDatos);
        NuevaConversion = new ConversionNueva(NuevosDatos);
        CargaPaises();
        txtruta1.setVisible(false);
        txtRuta.setVisible(false);
        arrayCliente = new ArrayCliente();
        arrayConversiones = new ArrayConversiones();
        listarInformeMonedas();
        try {
            cargar_txt();
            cargar_txt1();
            listarRegistro();
            listarRegistro1();
            listarInformeMonedas();

        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "No existe el archivo txt");
        }

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTabbedPane1 = new javax.swing.JTabbedPane();
        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        cbZMonedaDestino = new javax.swing.JComboBox<>();
        cbZMonedaOrigen = new javax.swing.JComboBox<>();
        txtMonedaDestino = new javax.swing.JTextField();
        txtMonedaOrigen = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        btnConvertir = new javax.swing.JButton();
        jLabel4 = new javax.swing.JLabel();
        txtDolaresVendidos = new javax.swing.JTextField();
        txtDolaresComprados = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        txtIDClienteCoversion = new javax.swing.JTextField();
        jLabel15 = new javax.swing.JLabel();
        txtruta1 = new javax.swing.JTextField();
        jPanel3 = new javax.swing.JPanel();
        jPanel5 = new javax.swing.JPanel();
        jPInputBox = new javax.swing.JPanel();
        jLabel8 = new javax.swing.JLabel();
        txtNombreMoneda = new javax.swing.JTextField();
        jPInputBox1 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        txtPrecioCompra = new javax.swing.JTextField();
        jPInputBox3 = new javax.swing.JPanel();
        jLabel11 = new javax.swing.JLabel();
        txtPrecioVenta = new javax.swing.JTextField();
        btnAgregar = new javax.swing.JButton();
        jPanel4 = new javax.swing.JPanel();
        jPanel6 = new javax.swing.JPanel();
        jPInputBox2 = new javax.swing.JPanel();
        jLabel10 = new javax.swing.JLabel();
        txtNombreMoneda1 = new javax.swing.JTextField();
        jPInputBox4 = new javax.swing.JPanel();
        jLabel12 = new javax.swing.JLabel();
        txtPrecioCompra1 = new javax.swing.JTextField();
        jPInputBox5 = new javax.swing.JPanel();
        jLabel13 = new javax.swing.JLabel();
        txtPrecioVenta1 = new javax.swing.JTextField();
        btnActualizar = new javax.swing.JButton();
        jPanel7 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTClientes = new javax.swing.JTable();
        jPanel10 = new javax.swing.JPanel();
        btnEditar = new javax.swing.JButton();
        btnEliminar = new javax.swing.JButton();
        btnAgregar1 = new javax.swing.JButton();
        jLabel16 = new javax.swing.JLabel();
        txtIDCliente = new javax.swing.JTextField();
        txtNombreCliente = new javax.swing.JTextField();
        jLabel21 = new javax.swing.JLabel();
        jLabel22 = new javax.swing.JLabel();
        txtApellidosCliente = new javax.swing.JTextField();
        jLabel23 = new javax.swing.JLabel();
        txtNacionalidadCliente = new javax.swing.JTextField();
        jLabel24 = new javax.swing.JLabel();
        txtEdadCliente = new javax.swing.JTextField();
        txtRuta = new javax.swing.JTextField();
        jPanel9 = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTInformes = new javax.swing.JTable();
        txtFiltro = new javax.swing.JTextField();
        jLabel14 = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        jScrollPane3 = new javax.swing.JScrollPane();
        jTMontos = new javax.swing.JTable();
        txtFiltroMonedaOrigen = new javax.swing.JTextField();
        txtFiltroMonedaDestino = new javax.swing.JTextField();
        jLabel17 = new javax.swing.JLabel();
        jLabel18 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        jLabel1.setText("CRUnion");

        cbZMonedaDestino.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cbZMonedaDestinoItemStateChanged(evt);
            }
        });

        cbZMonedaOrigen.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cbZMonedaOrigenItemStateChanged(evt);
            }
        });

        txtMonedaDestino.setEditable(false);

        txtMonedaOrigen.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtMonedaOrigenKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtMonedaOrigenKeyTyped(evt);
            }
        });

        jLabel2.setText("Moneda de origen");

        jLabel3.setText("Moneda de destino");

        btnConvertir.setText("Convertir");
        btnConvertir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConvertirActionPerformed(evt);
            }
        });

        jLabel4.setText("Digite el monto");

        txtDolaresVendidos.setEditable(false);

        txtDolaresComprados.setEditable(false);

        jLabel5.setText("Dolares Vendidos");

        jLabel6.setText("Dolares Comprados");

        jLabel7.setText("Monto a recibir");

        jLabel15.setText("ID cliente");

        txtruta1.setEditable(false);
        txtruta1.setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(298, 298, 298)
                        .addComponent(jLabel1))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(71, 71, 71)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                    .addComponent(txtIDClienteCoversion, javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(cbZMonedaOrigen, javax.swing.GroupLayout.Alignment.LEADING, 0, 166, Short.MAX_VALUE)
                                    .addComponent(txtMonedaOrigen, javax.swing.GroupLayout.Alignment.LEADING))
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 134, Short.MAX_VALUE)
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                .addComponent(txtMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)
                                                .addComponent(jLabel7))
                                            .addComponent(cbZMonedaDestino, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addGroup(jPanel1Layout.createSequentialGroup()
                                                .addComponent(jLabel3)
                                                .addGap(59, 59, 59)))
                                        .addGap(121, 121, 121)
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                                .addComponent(jLabel6)
                                                .addGap(60, 60, 60))
                                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                .addComponent(jLabel5)
                                                .addComponent(txtDolaresVendidos, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE))
                                            .addComponent(txtDolaresComprados, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addGap(83, 83, 83)
                                        .addComponent(txtruta1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(0, 0, Short.MAX_VALUE))))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel2)
                                    .addComponent(jLabel4)
                                    .addComponent(jLabel15))
                                .addGap(0, 0, Short.MAX_VALUE)))))
                .addGap(51, 51, 51))
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(389, 389, 389)
                .addComponent(btnConvertir, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 66, Short.MAX_VALUE)
                .addComponent(jLabel15)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtIDClienteCoversion, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtruta1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel6, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel2))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(cbZMonedaOrigen, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(9, 9, 9))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addComponent(txtDolaresComprados, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(23, 23, 23)))
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel4)
                            .addComponent(jLabel5))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtMonedaOrigen, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtDolaresVendidos, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(cbZMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(9, 9, 9)
                        .addComponent(jLabel7)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(27, 27, 27)
                .addComponent(btnConvertir, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(25, 25, 25))
        );

        jTabbedPane1.addTab("Conversión de divisas", jPanel1);

        jPanel5.setLayout(new javax.swing.BoxLayout(jPanel5, javax.swing.BoxLayout.Y_AXIS));

        jPInputBox.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel8.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel8.setText("Nombre moneda");
        jLabel8.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox.add(jLabel8);

        txtNombreMoneda.setPreferredSize(new java.awt.Dimension(274, 35));
        jPInputBox.add(txtNombreMoneda);

        jPanel5.add(jPInputBox);

        jPInputBox1.setPreferredSize(new java.awt.Dimension(360, 2));
        jPInputBox1.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel9.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel9.setText("Precio de compra");
        jLabel9.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox1.add(jLabel9);

        txtPrecioCompra.setPreferredSize(new java.awt.Dimension(274, 35));
        txtPrecioCompra.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtPrecioCompraKeyTyped(evt);
            }
        });
        jPInputBox1.add(txtPrecioCompra);

        jPanel5.add(jPInputBox1);

        jPInputBox3.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox3.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel11.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel11.setText("Precio de venta");
        jLabel11.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox3.add(jLabel11);

        txtPrecioVenta.setPreferredSize(new java.awt.Dimension(274, 35));
        txtPrecioVenta.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtPrecioVentaKeyTyped(evt);
            }
        });
        jPInputBox3.add(txtPrecioVenta);

        jPanel5.add(jPInputBox3);

        btnAgregar.setText("Agregar");
        btnAgregar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAgregarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                .addContainerGap(451, Short.MAX_VALUE)
                .addComponent(btnAgregar, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(344, 344, 344))
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel3Layout.createSequentialGroup()
                    .addGap(126, 126, 126)
                    .addComponent(jPanel5, javax.swing.GroupLayout.DEFAULT_SIZE, 627, Short.MAX_VALUE)
                    .addGap(127, 127, 127)))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                .addContainerGap(377, Short.MAX_VALUE)
                .addComponent(btnAgregar)
                .addGap(32, 32, 32))
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel3Layout.createSequentialGroup()
                    .addGap(34, 34, 34)
                    .addComponent(jPanel5, javax.swing.GroupLayout.PREFERRED_SIZE, 277, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(122, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("Agregar monedas", jPanel3);

        jPanel6.setLayout(new javax.swing.BoxLayout(jPanel6, javax.swing.BoxLayout.Y_AXIS));

        jPInputBox2.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox2.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel10.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel10.setText("Nombre moneda");
        jLabel10.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox2.add(jLabel10);

        txtNombreMoneda1.setPreferredSize(new java.awt.Dimension(274, 35));
        jPInputBox2.add(txtNombreMoneda1);

        jPanel6.add(jPInputBox2);

        jPInputBox4.setPreferredSize(new java.awt.Dimension(360, 2));
        jPInputBox4.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel12.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel12.setText("Precio de compra");
        jLabel12.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox4.add(jLabel12);

        txtPrecioCompra1.setPreferredSize(new java.awt.Dimension(274, 35));
        txtPrecioCompra1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtPrecioCompra1KeyTyped(evt);
            }
        });
        jPInputBox4.add(txtPrecioCompra1);

        jPanel6.add(jPInputBox4);

        jPInputBox5.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox5.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel13.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel13.setText("Precio de venta");
        jLabel13.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox5.add(jLabel13);

        txtPrecioVenta1.setPreferredSize(new java.awt.Dimension(274, 35));
        txtPrecioVenta1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtPrecioVenta1KeyTyped(evt);
            }
        });
        jPInputBox5.add(txtPrecioVenta1);

        jPanel6.add(jPInputBox5);

        btnActualizar.setText("Actualizar");
        btnActualizar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnActualizarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(346, 346, 346)
                .addComponent(btnActualizar, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(449, Short.MAX_VALUE))
            .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel4Layout.createSequentialGroup()
                    .addGap(126, 126, 126)
                    .addComponent(jPanel6, javax.swing.GroupLayout.DEFAULT_SIZE, 627, Short.MAX_VALUE)
                    .addGap(127, 127, 127)))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addContainerGap(381, Short.MAX_VALUE)
                .addComponent(btnActualizar)
                .addGap(28, 28, 28))
            .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel4Layout.createSequentialGroup()
                    .addGap(47, 47, 47)
                    .addComponent(jPanel6, javax.swing.GroupLayout.PREFERRED_SIZE, 277, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(109, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("Actualizar monedas", jPanel4);

        jTClientes = new javax.swing.JTable(){
            public boolean isCellEditable(int rowIndex,int colIndex){
                return false;
            }
        };
        jTClientes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4", "Title 5"
            }
        ));
        jTClientes.getTableHeader().setResizingAllowed(false);
        jTClientes.getTableHeader().setReorderingAllowed(false);
        jTClientes.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTClientesMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTClientes);

        btnEditar.setText("Editar");
        btnEditar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEditarActionPerformed(evt);
            }
        });

        btnEliminar.setText("Eliminar");
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });

        btnAgregar1.setText("Agregar");
        btnAgregar1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAgregar1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel10Layout = new javax.swing.GroupLayout(jPanel10);
        jPanel10.setLayout(jPanel10Layout);
        jPanel10Layout.setHorizontalGroup(
            jPanel10Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel10Layout.createSequentialGroup()
                .addContainerGap(438, Short.MAX_VALUE)
                .addComponent(btnAgregar1, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(btnEditar, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 98, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(21, 21, 21))
        );
        jPanel10Layout.setVerticalGroup(
            jPanel10Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel10Layout.createSequentialGroup()
                .addGroup(jPanel10Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnEliminar)
                    .addComponent(btnEditar)
                    .addComponent(btnAgregar1))
                .addContainerGap(76, Short.MAX_VALUE))
        );

        jLabel16.setText("ID");

        txtIDCliente.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtIDClienteKeyTyped(evt);
            }
        });

        jLabel21.setText("Nombre");

        jLabel22.setText("Apellidos");

        jLabel23.setText("Nacionalidad");

        jLabel24.setText("Edad");

        txtEdadCliente.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtEdadClienteKeyTyped(evt);
            }
        });

        txtRuta.setEditable(false);

        javax.swing.GroupLayout jPanel7Layout = new javax.swing.GroupLayout(jPanel7);
        jPanel7.setLayout(jPanel7Layout);
        jPanel7Layout.setHorizontalGroup(
            jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel10, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGroup(jPanel7Layout.createSequentialGroup()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 411, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(jPanel7Layout.createSequentialGroup()
                        .addComponent(jLabel23)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(txtNacionalidadCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 170, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel7Layout.createSequentialGroup()
                        .addComponent(jLabel24)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(txtEdadCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 170, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel7Layout.createSequentialGroup()
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel22)
                            .addComponent(jLabel21)
                            .addComponent(jLabel16))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtIDCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 170, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtApellidosCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 170, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtNombreCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 170, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(txtRuta, javax.swing.GroupLayout.PREFERRED_SIZE, 57, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        jPanel7Layout.setVerticalGroup(
            jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel7Layout.createSequentialGroup()
                .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 282, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(jPanel7Layout.createSequentialGroup()
                        .addGap(36, 36, 36)
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtIDCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel16)
                            .addComponent(txtRuta, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(19, 19, 19)
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtNombreCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel21))
                        .addGap(21, 21, 21)
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtApellidosCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel22))
                        .addGap(15, 15, 15)
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtNacionalidadCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel23))
                        .addGap(15, 15, 15)
                        .addGroup(jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtEdadCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel24))))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jPanel10, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        jTabbedPane1.addTab("Agregar, modificar o eliminar clientes", jPanel7);

        jTInformes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jTInformes.getTableHeader().setReorderingAllowed(false);
        jScrollPane2.setViewportView(jTInformes);

        txtFiltro.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtFiltroKeyTyped(evt);
            }
        });

        jLabel14.setText("Filtrar por ID");

        javax.swing.GroupLayout jPanel9Layout = new javax.swing.GroupLayout(jPanel9);
        jPanel9.setLayout(jPanel9Layout);
        jPanel9Layout.setHorizontalGroup(
            jPanel9Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 880, Short.MAX_VALUE)
            .addGroup(jPanel9Layout.createSequentialGroup()
                .addGap(15, 15, 15)
                .addComponent(jLabel14)
                .addGap(27, 27, 27)
                .addComponent(txtFiltro, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel9Layout.setVerticalGroup(
            jPanel9Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel9Layout.createSequentialGroup()
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 274, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 84, Short.MAX_VALUE)
                .addGroup(jPanel9Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel14)
                    .addComponent(txtFiltro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(51, 51, 51))
        );

        jTabbedPane1.addTab("Informes Conversiones", jPanel9);

        jTMontos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane3.setViewportView(jTMontos);

        txtFiltroMonedaOrigen.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtFiltroMonedaOrigenKeyTyped(evt);
            }
        });

        txtFiltroMonedaDestino.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtFiltroMonedaDestinoKeyTyped(evt);
            }
        });

        jLabel17.setText("Filtrar por Moneda de origen:");

        jLabel18.setText("Filtrar por Moneda de destino:");

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jLabel18)
                    .addComponent(jLabel17))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtFiltroMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtFiltroMonedaOrigen, javax.swing.GroupLayout.PREFERRED_SIZE, 67, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(623, Short.MAX_VALUE))
            .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addComponent(jScrollPane3, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 880, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(312, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtFiltroMonedaOrigen, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel17))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtFiltroMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel18))
                .addGap(55, 55, 55))
            .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                    .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 288, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(139, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("Informe monedas", jPanel2);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jTabbedPane1)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnAgregar1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAgregar1ActionPerformed

        if (!Vacio2()) {
            try {
            if (validarEdad() == false) {
                JOptionPane.showMessageDialog(this, "Tiene que ser una edad mayor a 18!", "Edad erronea", JOptionPane.WARNING_MESSAGE);
            } else {
                /*esto de recibir un txt vacio no lo entiendo muy bien, supongo que asi funciona el metodo y se tendra que instanciar asi
        esto lo hice siguiendo los pasos del los ejemplos que subio el profesor wilfrido*/
                File ruta = new File(txtRuta.getText());
                ingresarRegistro(ruta);
            }
        } catch (HeadlessException headlessException) {
            JOptionPane.showMessageDialog(this, "Ha ocurrido un error");
        }
        }else {
            JOptionPane.showMessageDialog(this, "No pueden quedar espacios vacios");
        }
  


    }//GEN-LAST:event_btnAgregar1ActionPerformed

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarActionPerformed
        eliminarRegistro();
    }//GEN-LAST:event_btnEliminarActionPerformed

    private void btnEditarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEditarActionPerformed
        if (!Vacio2()) {
             try {
            if (validarEdad() == false) {
                JOptionPane.showMessageDialog(this, "Tiene que ser una edad mayor a 18!", "Edad erronea", JOptionPane.WARNING_MESSAGE);
            } else {
                /*esto de recibir un txt vacio no lo entiendo muy bien, supongo que asi funciona el metodo y se tendra que instanciar asi
        esto lo hice siguiendo los pasos del los ejemplos que subio el profesor wilfrido*/
                File ruta = new File(txtRuta.getText());
                modificarRegistro(ruta);
            }
        } catch (HeadlessException headlessException) {
            JOptionPane.showMessageDialog(this, "Ha ocurrido un error");
        }
        }else {
            JOptionPane.showMessageDialog(this, "No pueden quedar espacios vacios");
        }
       


    }//GEN-LAST:event_btnEditarActionPerformed

    //en este metodo lo que hago es que al seleccionar un cliente el la tabla le carga los datos en las cajas de texto para poder editarlas
    private void jTClientesMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTClientesMouseClicked

        try {
            clic_tabla = jTClientes.rowAtPoint(evt.getPoint());

            int id = (int) jTClientes.getValueAt(clic_tabla, 0);
            String nombre = "" + jTClientes.getValueAt(clic_tabla, 1);
            String apellido = "" + jTClientes.getValueAt(clic_tabla, 2);
            String nacionalidad = "" + jTClientes.getValueAt(clic_tabla, 3);
            int edad = (int) jTClientes.getValueAt(clic_tabla, 4);
            txtIDCliente.setText(String.valueOf(id));
            txtNombreCliente.setText(nombre);
            txtApellidosCliente.setText(apellido);
            txtNacionalidadCliente.setText(nacionalidad);
            txtEdadCliente.setText(String.valueOf(edad));
        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Ha ocurrido un error");
        }
    }//GEN-LAST:event_jTClientesMouseClicked

    private void btnActualizarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActualizarActionPerformed
        //a diferencia de la primera tarea aqui ya agregue los try catch para manejar cualquier error no previsto
        //el if verifica que ninguna caja de texto este vacia si hay alguna vacia entonces devuelve un mensaje y sino entonces ejecuta el codigo
        if (!Vacio1()) {
            try {
                String NombreMoneda = txtNombreMoneda1.getText();
                Float PrecioCompra = Float.parseFloat(txtPrecioCompra1.getText());
                Float PrecioVenta = Float.parseFloat(txtPrecioVenta1.getText());
                if (NuevosDatos.ActualizarValoresEquivalencias(NombreMoneda, PrecioCompra, PrecioVenta)) {
                    JOptionPane.showMessageDialog(this, "Moneda Actualizada");
                } else {
                    JOptionPane.showMessageDialog(this, "La moneda no existe");
                }
            } catch (NumberFormatException numberFormatException) {
                JOptionPane.showMessageDialog(this, "Hay tipos de datos invalidos");
            } catch (HeadlessException headlessException) {
                JOptionPane.showMessageDialog(this, "Ha ocurrido un error");
            }
        } else {
            JOptionPane.showMessageDialog(this, "No pueden quedar espacios vacios");
        }
    }//GEN-LAST:event_btnActualizarActionPerformed

    private void txtPrecioVenta1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioVenta1KeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioVenta1KeyTyped

    private void txtPrecioCompra1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioCompra1KeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioCompra1KeyTyped

    private void btnAgregarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAgregarActionPerformed
        //a diferencia de la primera tarea aqui ya agregue los try catch para manejar cualquier error no previsto
        //el if verifica que ninguna caja de texto este vacia si hay alguna vacia entonces devuelve un mensaje y sino entonces ejecuta el codigo
        if (!Vacio()) {
            try {
                String NombreMoneda = txtNombreMoneda.getText();
                Float PrecioCompra = Float.parseFloat(txtPrecioCompra.getText());
                Float PrecioVenta = Float.parseFloat(txtPrecioVenta.getText());
                //aqui se le pasan los valores de las cajas para agregarlos
                boolean estado = NuevosDatos.AgregarNuevaEquivalencia(NombreMoneda, PrecioCompra, PrecioVenta);
                //si la moneda no existe entra al verdadero y carga el nuevo pais a la lista del combo box
                if (estado) {
                    JOptionPane.showMessageDialog(this, "Moneda Agregada");

                    CargaPaises();
                    //si la moneda existe devuelve un falso ya que es un boolean y entonces no agrega ningun valor
                } else {
                    JOptionPane.showMessageDialog(this, "La moneda ya existe");
                }
            } catch (Exception e) {
                JOptionPane.showMessageDialog(this, "Hay tipos de datos invalidos");
            }
        } else {
            JOptionPane.showMessageDialog(this, "No pueden quedar espacios vacios");
        }
    }//GEN-LAST:event_btnAgregarActionPerformed

    private void txtPrecioVentaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioVentaKeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioVentaKeyTyped

    private void txtPrecioCompraKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioCompraKeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioCompraKeyTyped

    private void btnConvertirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConvertirActionPerformed
        if (txtMonedaOrigen.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "No pueden quedar espacios vacios");
        } else {try {
            File ruta = new File(txtruta1.getText());
            AgregarConversion(ruta);
            conversion();
            listarRegistro1();
            listarInformeMonedas();
        } catch (Exception e) {
        }
        }
        


    }//GEN-LAST:event_btnConvertirActionPerformed

    private void txtIDClienteKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtIDClienteKeyTyped
        int caracter = evt.getKeyChar();
        if (txtIDCliente.getText().length() > 10) {
            getToolkit().beep();
            evt.consume();
        }
        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtIDClienteKeyTyped

    private void txtEdadClienteKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtEdadClienteKeyTyped
        int caracter = evt.getKeyChar();
        if (txtEdadCliente.getText().length() > 2) {
            getToolkit().beep();
            evt.consume();
        }
        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtEdadClienteKeyTyped

    private void cbZMonedaOrigenItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cbZMonedaOrigenItemStateChanged
        try {
            conversion();
        } catch (Exception e) {
        }
    }//GEN-LAST:event_cbZMonedaOrigenItemStateChanged

    private void cbZMonedaDestinoItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cbZMonedaDestinoItemStateChanged
        try {
            conversion();
        } catch (Exception e) {
        }
    }//GEN-LAST:event_cbZMonedaDestinoItemStateChanged

    private void txtMonedaOrigenKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtMonedaOrigenKeyTyped

        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

            JOptionPane.showMessageDialog(this, "Digite solo números");
        }
        // TODO add your handling code here:
    }//GEN-LAST:event_txtMonedaOrigenKeyTyped

    private void txtMonedaOrigenKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtMonedaOrigenKeyReleased
        try {
            conversion();
        } catch (Exception e) {
        }
    }//GEN-LAST:event_txtMonedaOrigenKeyReleased

    private void txtFiltroKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtFiltroKeyTyped
        //El filtro de la tabla se hizo con ayuda de este video https://www.youtube.com/watch?v=7CDV9IJMifw

        txtFiltro.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                trs.setRowFilter(RowFilter.regexFilter(txtFiltro.getText(), 0));
            }
        });
        trs = new TableRowSorter(jTInformes.getModel());
        jTInformes.setRowSorter(trs);
    }//GEN-LAST:event_txtFiltroKeyTyped

    private void txtFiltroMonedaOrigenKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtFiltroMonedaOrigenKeyTyped
        txtFiltroMonedaOrigen.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                trs.setRowFilter(RowFilter.regexFilter("(?i)"+txtFiltroMonedaOrigen.getText(), 0));
            }
        });
        trs = new TableRowSorter(jTMontos.getModel());
        jTMontos.setRowSorter(trs);
    }//GEN-LAST:event_txtFiltroMonedaOrigenKeyTyped

    private void txtFiltroMonedaDestinoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtFiltroMonedaDestinoKeyTyped
        txtFiltroMonedaDestino.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                trs.setRowFilter(RowFilter.regexFilter("(?i)"+txtFiltroMonedaDestino.getText(), 2));
            }
        });
        trs = new TableRowSorter(jTMontos.getModel());
        jTMontos.setRowSorter(trs);
    }//GEN-LAST:event_txtFiltroMonedaDestinoKeyTyped

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(() -> {
            new MenuPrincipal().setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnActualizar;
    private javax.swing.JButton btnAgregar;
    private javax.swing.JButton btnAgregar1;
    private javax.swing.JButton btnConvertir;
    private javax.swing.JButton btnEditar;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JComboBox<String> cbZMonedaDestino;
    private javax.swing.JComboBox<String> cbZMonedaOrigen;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel17;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel21;
    private javax.swing.JLabel jLabel22;
    private javax.swing.JLabel jLabel23;
    private javax.swing.JLabel jLabel24;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPInputBox;
    private javax.swing.JPanel jPInputBox1;
    private javax.swing.JPanel jPInputBox2;
    private javax.swing.JPanel jPInputBox3;
    private javax.swing.JPanel jPInputBox4;
    private javax.swing.JPanel jPInputBox5;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel10;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JPanel jPanel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JTable jTClientes;
    private javax.swing.JTable jTInformes;
    private javax.swing.JTable jTMontos;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTextField txtApellidosCliente;
    private javax.swing.JTextField txtDolaresComprados;
    private javax.swing.JTextField txtDolaresVendidos;
    private javax.swing.JTextField txtEdadCliente;
    private javax.swing.JTextField txtFiltro;
    private javax.swing.JTextField txtFiltroMonedaDestino;
    private javax.swing.JTextField txtFiltroMonedaOrigen;
    private javax.swing.JTextField txtIDCliente;
    private javax.swing.JTextField txtIDClienteCoversion;
    private javax.swing.JTextField txtMonedaDestino;
    private javax.swing.JTextField txtMonedaOrigen;
    private javax.swing.JTextField txtNacionalidadCliente;
    private javax.swing.JTextField txtNombreCliente;
    private javax.swing.JTextField txtNombreMoneda;
    private javax.swing.JTextField txtNombreMoneda1;
    private javax.swing.JTextField txtPrecioCompra;
    private javax.swing.JTextField txtPrecioCompra1;
    private javax.swing.JTextField txtPrecioVenta;
    private javax.swing.JTextField txtPrecioVenta1;
    private javax.swing.JTextField txtRuta;
    private javax.swing.JTextField txtruta1;
    // End of variables declaration//GEN-END:variables

//cargar ComboBox
    private void CargaPaises() {

        cbZMonedaOrigen.removeAllItems();
        cbZMonedaDestino.removeAllItems();

        for (String pais : NuevosDatos.getDescripcionMonedas()) {

            cbZMonedaOrigen.addItem(pais);
            cbZMonedaDestino.addItem(pais);

        }
    }
//estos metodos son para verificar que no se queden espacio en blanco

    private boolean Vacio() {

        return txtNombreMoneda.getText().isEmpty() || txtPrecioCompra.getText().isEmpty() || txtPrecioVenta.getText().isEmpty();
    }

    private boolean Vacio1() {
        return txtNombreMoneda1.getText().isEmpty() || txtPrecioCompra1.getText().isEmpty() || txtPrecioVenta1.getText().isEmpty();
    }
    private boolean Vacio2() {
        
        return txtIDCliente.getText().isEmpty()||txtNombreCliente.getText().isEmpty()||txtApellidosCliente.getText().isEmpty()||txtNacionalidadCliente.getText().isEmpty()||
                txtEdadCliente.getText().isEmpty();
        
    }
//aqui se carga el txt
    public void cargar_txt() {
        File ruta = new File(ruta_txt);//aqui recibe la ruta del text que se declaro antes como "Clientes.txt"
        try {

            FileReader fi = new FileReader(ruta);
            BufferedReader bu = new BufferedReader(fi);

            String linea = null;
            while ((linea = bu.readLine()) != null) {
                StringTokenizer st = new StringTokenizer(linea, "|");
                cliente = new Cliente();
                cliente.setIDCliente(Integer.parseInt(st.nextToken()));
                cliente.setNombre(st.nextToken());
                cliente.setApellidos(st.nextToken());
                cliente.setNacionalidad(st.nextToken());
                cliente.setEdad(Integer.parseInt(st.nextToken()));
                arrayCliente.agregarRegistro(cliente);
            }
            bu.close();
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error al cargar el archivo");//si el archivo no existe dara un error de carga
            System.out.println(ex.getMessage());
        }
    }

    public void cargar_txt1() {
        File ruta = new File(ruta_txt1);//aqui recibe la ruta del text que se declaro antes como "Informes.txt"
        try {

            FileReader fi = new FileReader(ruta);
            BufferedReader bu = new BufferedReader(fi);

            String linea = null;
            while ((linea = bu.readLine()) != null) {
                StringTokenizer st = new StringTokenizer(linea, "|");
                informeConversiones = new InformeConversiones();
                informeConversiones.setId(Integer.parseInt(st.nextToken()));
                informeConversiones.setMonedaOrigen(st.nextToken());
                informeConversiones.setMontoRecibido(Float.parseFloat(st.nextToken()));
                informeConversiones.setMonedaDestino(st.nextToken());
                informeConversiones.setMontoARecibir(Float.parseFloat(st.nextToken()));
                informeConversiones.setDolaresComprados(Float.parseFloat(st.nextToken()));
                informeConversiones.setDolaresVendidos(Float.parseFloat(st.nextToken()));
                arrayConversiones.agregarConversion(informeConversiones);

            }
            bu.close();
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error al cargar el archivo");//si el archivo no existe dara un error de carga
            System.out.println(ex.getMessage());
        }
    }
//este metodo es el que guarda todos los cambios que se hagan en el archivo, ya se que se añada, se edite o se elimine
    public void grabar_txt() {
        FileWriter fw;
        PrintWriter pw;
        try {
            fw = new FileWriter(ruta_txt);
            pw = new PrintWriter(fw);

            for (int i = 0; i < arrayCliente.cantidadRegistro(); i++) {
                cliente = arrayCliente.obtenerRegistro(i);
                pw.println(String.valueOf(cliente.getIDCliente() + "|" + cliente.getNombre() + "|" + cliente.getApellidos() + "|" + cliente.getNacionalidad() + "|" + cliente.getEdad()));
            }
            pw.close();

        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error al guardar el archivo");
            System.out.println(ex.getMessage());
        }
    }
    //este metodo es para grabar el otro txt de los informes
    public void grabar_txt1() {
        FileWriter fw;
        PrintWriter pw;
        try {
            fw = new FileWriter(ruta_txt1);
            pw = new PrintWriter(fw);

            for (int i = 0; i < arrayConversiones.cantidadRegistro(); i++) {
                informeConversiones = arrayConversiones.obtenerRegistro(i);
                pw.println(String.valueOf(informeConversiones.getId() + "|" + informeConversiones.getMonedaOrigen() + "|" + informeConversiones.getMontoRecibido() + "|"
                        + informeConversiones.getMonedaDestino() + "|" + informeConversiones.getMontoARecibir() + "|" + informeConversiones.getDolaresComprados()
                        + "|" + informeConversiones.getDolaresVendidos()));
            }
            pw.close();

        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error al guardar el archivo");
            System.out.println(ex.getMessage());
        }
    }
//este metodo es para ingresar un usuario nuevo
    public void ingresarRegistro(File ruta) //este metodo recibe por parametro un archivo por lo cuando se invoque se tendra que pasar el archivo en mi caso "Clientes.txt"
    {
        try {
            if (leerID() == 666) {
                JOptionPane.showMessageDialog(this, "Ingresar numero entero");
            } else if (leerNombre() == null) {
                JOptionPane.showMessageDialog(this, "Ingresar nombre");
            } else if (leerApellido() == null) {
                JOptionPane.showMessageDialog(this, "Ingresar Apellido");
            } else if (leerNacionalidad() == null) {
                JOptionPane.showMessageDialog(this, "Ingresar nacionalidad");
            } else if (leerEdad() == 666) {
                JOptionPane.showMessageDialog(this, "Ingresar edad");
            } else if (validarEdad() == false) {

            } else {
                cliente = new Cliente(leerID(), leerNombre(), leerApellido(), leerNacionalidad(), leerEdad());
                if (arrayCliente.buscaCodigo(cliente.getIDCliente()) != -1) {
                    JOptionPane.showMessageDialog(this, "Este ID ya existe");
                } else {
                    arrayCliente.agregarRegistro(cliente);
                    JOptionPane.showMessageDialog(this, "El cliente se agrego correctamente");
                    limpiarCajas();
                }

                grabar_txt();
                listarRegistro();

            }
        } catch (Exception ex) {

        }
    }
    //este el es metodo que se utiliza para agregar la conversion y tambien se validan las validaciones que se piden en el enunciado
    public void AgregarConversion(File ruta) {
        try {
            if (leerIDConversion() == 666) {
            } else if (leerMonedaOrigen() == null) {

            } else if (leerMonto() == 666) {

            } else if (leerMonedaDestino() == null) {

            } else if (leerMontoRecibir() == 666) {

            } else if (leerDolaresCompra() == 666) {

            } else if (leerDolaresVenta() == 666) {

            } else {
                int codigo = arrayCliente.buscaCodigo(leerIDConversion());
                informeConversiones = new InformeConversiones(leerIDConversion(), leerMonedaOrigen(), leerMonto(), leerMonedaDestino(), leerMontoRecibir(), leerDolaresCompra(), leerDolaresVenta());
                if (codigo == -1) {
                    arrayCliente.agregarRegistro(cliente);
                    JOptionPane.showMessageDialog(this, "El numero de id no existe");
                } else {
                    int s = JOptionPane.showConfirmDialog(null, "Desea aceptar la conversión?", "Si/No", 0);
                    if (s == 0) {
                        arrayConversiones.agregarConversion(informeConversiones);
                        JOptionPane.showMessageDialog(this, "La conversion se hizo correctamente");
                        grabar_txt1();
                        listarRegistro1();
                    }

                }

                grabar_txt1();
                listarRegistro1();

            }

        } catch (Exception e) {
            
        }
    }
    //este metodo es para eliminar el registro que se seleccione

    public void eliminarRegistro() {
        try {
            if (leerID() == -666) {
                JOptionPane.showMessageDialog(this, "Ingrese el codigo correctamente");
            } else {
                int codigo = arrayCliente.buscaCodigo(leerID());
                if (codigo == -1) {
                    JOptionPane.showMessageDialog(this, "Codigo no existe");
                    
                } if (codigo == arrayConversiones.buscaCodigo(leerID())) {
                    JOptionPane.showMessageDialog(this, "Este ID ya tiene conversiones");/*aqui se busca en la array de las conversiones 
                                                                                           si el codigo ya existe y si existe no se puede eliminar*/
                }
                else {
                    int s = JOptionPane.showConfirmDialog(null, "Esta seguro de eliminar a este cliente", "Si/No", 0);
                    if (s == 0) {
                        arrayCliente.eliminarRegistro(codigo);
                        grabar_txt();
                        listarRegistro();
                        limpiarCajas();
                        JOptionPane.showMessageDialog(this, "El cliente se elimino correctamente");
                    }
                }

            }
        } catch (Exception ex) {

        }
    }

    //este metodo es para editar el cliente que se seleccione en la tabla
    public void modificarRegistro(File ruta) {
        try {
            if (leerID() == 666) {
                JOptionPane.showMessageDialog(this, "Ingrese el codigo correctamente");
            } else if (leerNombre() == null) {
                JOptionPane.showMessageDialog(this, "Ingrese el nombre");
            } else if (leerApellido() == null) {
                JOptionPane.showMessageDialog(this, "Ingrese el la nacionalidad");
            } else if (leerNacionalidad() == null) {
                JOptionPane.showMessageDialog(this, "Ingrese la edad");
            } else if (leerEdad() == 666) {
                JOptionPane.showMessageDialog(this, "Edad incorrecta");
            } else if (validarEdad() == false) {

            } else {
                int codigo = arrayCliente.buscaCodigo(leerID());
                cliente = new Cliente(leerID(), leerNombre(), leerApellido(), leerNacionalidad(), leerEdad());
                limpiarCajas();
                if (codigo == -1) {
                    arrayCliente.agregarRegistro(cliente);
                    limpiarCajas();
                    JOptionPane.showMessageDialog(this, "El cliente se agrego correctamente");
                } else {
                    arrayCliente.modificarRegistro(codigo, cliente);
                    limpiarCajas();
                    JOptionPane.showMessageDialog(this, "El cliente se modifico correctamente");
                }

                grabar_txt();
                listarRegistro();

            }
        } catch (Exception ex) {

        }
    }
/*este es el metodo para llenar el informe de las monedas, segun entiendo deben poder agrupar o filtrar por moneda de origen o de destino
  por lo que debajo de la tabla agregue dos jtextfield para poder escribir el nombre de la moneda a filtrar*/  
    public void listarInformeMonedas() {
        DefaultTableModel dt = new DefaultTableModel() {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };

        dt.addColumn("Moneda de origen");
        dt.addColumn("Monto convertido");
        dt.addColumn("Moneda destino");
        dt.addColumn("Monto entregado");

        Object fila[] = new Object[dt.getColumnCount()];
        for (int i = 0; i < arrayConversiones.cantidadRegistro(); i++) {
            informeConversiones = arrayConversiones.obtenerRegistro(i);
            
            fila[0] = informeConversiones.getMonedaOrigen();
            fila[1] = informeConversiones.getMontoRecibido();
            fila[2] = informeConversiones.getMonedaDestino();
            fila[3] = informeConversiones.getMontoARecibir();

            dt.addRow(fila);
        }
        jTMontos.setModel(dt);
    }

    //este metodo se utiliza para rellenar la tabla en donde de editan, agregan y elminan los clientes
    public void listarRegistro() {
        DefaultTableModel dtm = new DefaultTableModel() {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };

        dtm.addColumn("ID");
        dtm.addColumn("Nombre");
        dtm.addColumn("Apellido");
        dtm.addColumn("Nacionalidad");
        dtm.addColumn("Edad");
        
        Object fila[] = new Object[dtm.getColumnCount()];
        for (int i = 0; i < arrayCliente.cantidadRegistro(); i++) {
            cliente = arrayCliente.obtenerRegistro(i);
            fila[0] = cliente.getIDCliente();//a partir de aqui le voy asignando uno por uno donde debe ir cada dato en la tabla
            fila[1] = cliente.getNombre();
            fila[2] = cliente.getApellidos();
            fila[3] = cliente.getNacionalidad();
            fila[4] = cliente.getEdad();
            dtm.addRow(fila);
        }
        jTClientes.setModel(dtm);

    }

//este es para llenar la tabla de los informes de conversion de cada cliente
    public void listarRegistro1() {
        DefaultTableModel dt = new DefaultTableModel() {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        dt.addColumn("ID");
        dt.addColumn("Moneda de origen");
        dt.addColumn("Monto a convertir");
        dt.addColumn("Moneda destino");
        dt.addColumn("Monto a recibir");
        dt.addColumn("Dolares comprados");
        dt.addColumn("Dolares vendidos");

        Object fila[] = new Object[dt.getColumnCount()];
        for (int i = 0; i < arrayConversiones.cantidadRegistro(); i++) {
            informeConversiones = arrayConversiones.obtenerRegistro(i);
            fila[0] = informeConversiones.getId();
            fila[1] = informeConversiones.getMonedaOrigen();
            fila[2] = informeConversiones.getMontoRecibido();
            fila[3] = informeConversiones.getMonedaDestino();
            fila[4] = informeConversiones.getMontoARecibir();
            fila[5] = informeConversiones.getDolaresComprados();
            fila[6] = informeConversiones.getDolaresVendidos();
            dt.addRow(fila);
        }
        jTInformes.setModel(dt);

    }
    //todos los metodos de leer son basicamente para obtener lo que se escriba en los txt y devolverlo
    public int leerIDConversion() {
        try {
            int id = Integer.parseInt(txtIDClienteCoversion.getText().trim());
            return id;
        } catch (Exception ex) {
            return -666;
        }
    }

    public String leerMonedaOrigen() {
        try {
            String MonedaOrigen = cbZMonedaOrigen.getSelectedItem().toString().trim().replace(" ", "_");
            return MonedaOrigen;
        } catch (Exception ex) {
        }
        return null;

    }

    public float leerMonto() {
        try {
            float monto = Float.parseFloat(txtMonedaOrigen.getText());
            return monto;
        } catch (Exception ex) {
        }
        return -666;
    }

    public String leerMonedaDestino() {
        try {
            String MonedaDestino = cbZMonedaDestino.getSelectedItem().toString().trim().replace(" ", "_");
            return MonedaDestino;
        } catch (Exception ex) {
        }
        return null;
    }

    public float leerMontoRecibir() {
        try {
            float monto = Float.parseFloat(txtMonedaDestino.getText().trim());
            return monto;
        } catch (Exception ex) {
        }
        return 0;
    }

    public float leerDolaresCompra() {
        try {
            float monto = Float.parseFloat(txtDolaresComprados.getText().trim());
            return monto;
        } catch (Exception ex) {
        }
        return 0;
    }

    public float leerDolaresVenta() {
        try {
            float monto = Float.parseFloat(txtDolaresVendidos.getText().trim());
            return monto;
        } catch (Exception ex) {
        }
        return 0;
    }

    //este metodo lee el id ingresado en el txt
    public int leerID() {
        try {
            int id = Integer.parseInt(txtIDCliente.getText().trim());
            return id;
        } catch (Exception ex) {
            return -666;
        }
    }

    //este metodo lee el nombre ingresado en el txt correspondiente para devolverlo
    public String leerNombre() {
        try {
            String nombre = txtNombreCliente.getText().trim().replace(" ", "_");
            return nombre;
        } catch (Exception ex) {
            return null;
        }
    }

    //este metodo lee el apellido ingresado en el txt correspondiente para devolverlo
    public String leerApellido() {
        try {
            String apellido = txtApellidosCliente.getText().trim().replace(" ", "_");
            return apellido;
        } catch (Exception ex) {
            return null;
        }
    }

    //este metodo lee la nacionalidad ingresado en el txt correspondiente para devolverlo
    public String leerNacionalidad() {
        try {
            String nacionalidad = txtNacionalidadCliente.getText().trim().replace(" ", "_");
            return nacionalidad;
        } catch (Exception ex) {
            return null;
        }
    }
//este metodo lee la edad ingresada en el txt correspondiente para devolverlo

    public int leerEdad() {
        try {
            int edad = Integer.parseInt(txtEdadCliente.getText().trim());//como los txt solo reciben Strings se covierte a int
            return edad;
        } catch (Exception ex) {
            return -666;
        }
    }

    //para validar que sea mayor de edad
    public boolean validarEdad() {
        int val = Integer.parseInt(txtEdadCliente.getText());
        if (val < 18) { // Valida si es menor de edad
            JOptionPane.showMessageDialog(this, "La edad debe ser mayor a 18 años");
            txtEdadCliente.setText("");
        }
        return true;
    }

    //para limpiar las cajas de texto luego de agregar,editar o eliminar algun cliente
    public void limpiarCajas() {
        txtIDCliente.setText("");
        txtNombreCliente.setText("");
        txtApellidosCliente.setText("");
        txtNacionalidadCliente.setText("");
        txtEdadCliente.setText("");
    }

    //meti el codigo que tenia en los botones en metodos porque tengo que utilizar en validaciones entonces para no estarlo repitiendo
    public void conversion() {
        DecimalFormat formato = new DecimalFormat("0.00");//para formatear los decimales y que no aparezcan numeros tan grandes
        String monedaOrigen = cbZMonedaOrigen.getSelectedItem().toString();
        String monedaDestino = cbZMonedaDestino.getSelectedItem().toString();
        Float monto = Float.parseFloat(txtMonedaOrigen.getText());
        float conversion = convertidor.ConversionMoneda(monedaOrigen, monedaDestino, monto);
        txtMonedaDestino.setText(formato.format(conversion));
        float compraDolar = NuevaConversion.CompraDolares(monedaOrigen, monto);
        txtDolaresComprados.setText(formato.format(compraDolar));
        float ventaDolar = NuevaConversion.VentaDolares(monedaOrigen, monto);
        txtDolaresVendidos.setText(formato.format(ventaDolar));

    }



}
