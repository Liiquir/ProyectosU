/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package Ventanas;

/**
 *
 * @author josue
 */
import Clases.Conversion;
import Clases.ConversionNueva;
import Clases.Equivalencias;
import java.awt.event.KeyEvent;
import Clases.EquivalenciasNuevas;
import java.awt.HeadlessException;
import javax.swing.JOptionPane;

public class MenuPrincipal extends javax.swing.JFrame {

    EquivalenciasNuevas NuevosDatos;
    Conversion convertidor;
    ConversionNueva NuevaConversion;

    public MenuPrincipal() {
        initComponents();
        Equivalencias datos = new Equivalencias();
        NuevosDatos = new EquivalenciasNuevas(datos.getDescripcionMonedas(), datos.getTablaConversiones());
        convertidor = new Conversion(NuevosDatos);
        NuevaConversion = new ConversionNueva(NuevosDatos);
        CargaPaises();

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
        btnAgregar1 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        jLabel1.setText("CRUnion");

        txtMonedaDestino.setEditable(false);

        txtMonedaOrigen.addKeyListener(new java.awt.event.KeyAdapter() {
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

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btnConvertir, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(327, 327, 327))
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(298, 298, 298)
                        .addComponent(jLabel1))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(71, 71, 71)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel4)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(cbZMonedaOrigen, 0, 166, Short.MAX_VALUE)
                                    .addComponent(txtMonedaOrigen))
                                .addGap(92, 92, 92)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(txtMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jLabel7))
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 81, Short.MAX_VALUE)
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(jLabel5)
                                            .addComponent(txtDolaresVendidos, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                        .addComponent(cbZMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(txtDolaresComprados, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(jLabel3)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(jLabel6)
                                        .addGap(60, 60, 60)))))))
                .addGap(51, 51, 51))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 79, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel6, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel2)
                        .addComponent(jLabel3)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(cbZMonedaOrigen, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbZMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(9, 9, 9))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(txtDolaresComprados, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(23, 23, 23)))
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel4)
                        .addComponent(jLabel5))
                    .addComponent(jLabel7))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtMonedaDestino, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtMonedaOrigen, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtDolaresVendidos, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(36, 36, 36)
                .addComponent(btnConvertir, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(16, 16, 16))
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
                .addContainerGap(358, Short.MAX_VALUE)
                .addComponent(btnAgregar, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(344, 344, 344))
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel3Layout.createSequentialGroup()
                    .addGap(126, 126, 126)
                    .addComponent(jPanel5, javax.swing.GroupLayout.DEFAULT_SIZE, 534, Short.MAX_VALUE)
                    .addGap(127, 127, 127)))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                .addContainerGap(316, Short.MAX_VALUE)
                .addComponent(btnAgregar)
                .addGap(32, 32, 32))
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel3Layout.createSequentialGroup()
                    .addGap(34, 34, 34)
                    .addComponent(jPanel5, javax.swing.GroupLayout.PREFERRED_SIZE, 277, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(61, Short.MAX_VALUE)))
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

        btnAgregar1.setText("Actualizar");
        btnAgregar1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAgregar1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(346, 346, 346)
                .addComponent(btnAgregar1, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(356, Short.MAX_VALUE))
            .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel4Layout.createSequentialGroup()
                    .addGap(126, 126, 126)
                    .addComponent(jPanel6, javax.swing.GroupLayout.DEFAULT_SIZE, 534, Short.MAX_VALUE)
                    .addGap(127, 127, 127)))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addContainerGap(320, Short.MAX_VALUE)
                .addComponent(btnAgregar1)
                .addGap(28, 28, 28))
            .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel4Layout.createSequentialGroup()
                    .addGap(47, 47, 47)
                    .addComponent(jPanel6, javax.swing.GroupLayout.PREFERRED_SIZE, 277, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(48, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("Actualizar monedas", jPanel4);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(jTabbedPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 789, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(jTabbedPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 398, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnAgregar1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAgregar1ActionPerformed
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

    }//GEN-LAST:event_btnAgregar1ActionPerformed

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

    private void btnConvertirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConvertirActionPerformed
        //a diferencia de la primera tarea aqui ya agregue los try catch para manejar cualquier error no previsto
        //en la parte de compra y venta dolar podemos ver como ahora se llaman a los metodos de "CompraDolares" y "VentaDolares" mediante la nueva clase en donde se mejoran los metodos.
        try {
            String monedaOrigen = cbZMonedaOrigen.getSelectedItem().toString();
            String monedaDestino = cbZMonedaDestino.getSelectedItem().toString();
            Float monto = Float.parseFloat(txtMonedaOrigen.getText());
            float conversion = convertidor.ConversionMoneda(monedaOrigen, monedaDestino, monto);
            txtMonedaDestino.setText(conversion + "");
            float compraDolar = NuevaConversion.CompraDolares(monedaOrigen, monto);
            txtDolaresComprados.setText(compraDolar + "");
            float ventaDolar = NuevaConversion.VentaDolares(monedaOrigen, monto);
            txtDolaresVendidos.setText(ventaDolar + "");

        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Ha ocurrido un error");
        }


    }//GEN-LAST:event_btnConvertirActionPerformed

    private void txtMonedaOrigenKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtMonedaOrigenKeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

            JOptionPane.showMessageDialog(this, "Digite solo números");
        }         // TODO add your handling code here:
    }//GEN-LAST:event_txtMonedaOrigenKeyTyped

    private void txtPrecioCompraKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioCompraKeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioCompraKeyTyped

    private void txtPrecioVentaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioVentaKeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioVentaKeyTyped

    private void txtPrecioCompra1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioCompra1KeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioCompra1KeyTyped

    private void txtPrecioVenta1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrecioVenta1KeyTyped
        //para evitar que escriba letras
        char validar = evt.getKeyChar();
        if (Character.isLetter(validar)) {
            getToolkit().beep();
            evt.consume();

        }
    }//GEN-LAST:event_txtPrecioVenta1KeyTyped

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
    private javax.swing.JButton btnAgregar;
    private javax.swing.JButton btnAgregar1;
    private javax.swing.JButton btnConvertir;
    private javax.swing.JComboBox<String> cbZMonedaDestino;
    private javax.swing.JComboBox<String> cbZMonedaOrigen;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
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
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTextField txtDolaresComprados;
    private javax.swing.JTextField txtDolaresVendidos;
    private javax.swing.JTextField txtMonedaDestino;
    private javax.swing.JTextField txtMonedaOrigen;
    private javax.swing.JTextField txtNombreMoneda;
    private javax.swing.JTextField txtNombreMoneda1;
    private javax.swing.JTextField txtPrecioCompra;
    private javax.swing.JTextField txtPrecioCompra1;
    private javax.swing.JTextField txtPrecioVenta;
    private javax.swing.JTextField txtPrecioVenta1;
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
//estos metodos tantos Vacio como Vacio1 son para verificar que no se queden espacio en blanco

    private boolean Vacio() {

        return txtNombreMoneda.getText().isEmpty() || txtPrecioCompra.getText().isEmpty() || txtPrecioVenta.getText().isEmpty();
    }

    private boolean Vacio1() {
        return txtNombreMoneda1.getText().isEmpty() || txtPrecioCompra1.getText().isEmpty() || txtPrecioVenta1.getText().isEmpty();
    }

}
